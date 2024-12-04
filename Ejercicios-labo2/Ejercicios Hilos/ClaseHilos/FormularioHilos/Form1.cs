using System.Text;

namespace FormularioHilos
{
    public partial class Form1 : Form
    {
        CancellationTokenSource CancellationTokenSource; //creo variable cancelation token source.
        List<Task> tasks;

        public Form1()
        {
            InitializeComponent();
            tasks = new List<Task>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.IniciarHilos();
        }
        private void IniciarHilos()
        {
            //no se necesita el hilo.wait o wait all porque el formulario al hacer constante nunca va a terminar a menos que haga el closed.

            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;


            //El token es lo que nos va a permitir trabajar con hilos y pararlos en tiempo de ejecucion.
            CancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellation = CancellationTokenSource.Token;

            //asocio los cancellationtoken y cuando aprete el boton cancelar se van a cancelar.
            //en iniciar proceso agrego lo de cancellation para que funcione.
            Task task1 = new Task(() => IniciarProceso(progressBar1, label1), cancellation);
            Task task2 = new Task(() => IniciarProceso(progressBar2, label2), cancellation);
            Task task3 = new Task(() => IniciarProceso(progressBar3, label3), cancellation);
            Task task4 = new Task(() => IniciarProceso(progressBar4, label4), cancellation);
            Task task5 = new Task(() => IniciarProceso(progressBar5, label5), cancellation);

            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            task5.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void IniciarProceso(ProgressBar progressBar, Label label)
        {
            while (progressBar.Value < progressBar.Maximum && !CancellationTokenSource.IsCancellationRequested)
            {
                Thread.Sleep(new Random().Next(100, 1000));
                IncrementarBarraProgreso(progressBar, label, Task.CurrentId.Value); //Id del hilo actual.
            }

            FinalizarProceso(progressBar, label);
        }

        private void FinalizarProceso(ProgressBar progressBar, Label label)
        {
            //tengo que hacer el invoke required por cada cosa que haga, sino va a tirar el error de hilo equivado.
            if (InvokeRequired)
            {
                object[] parametros = new object[] { progressBar, label };
                Action<ProgressBar, Label> delegado;
                delegado = FinalizarProceso;
                Invoke(delegado, parametros);
            }
            else
            {
                if (progressBar.Value == progressBar.Maximum)
                {
                    label.Text = "FINALIZADO";
                }
                else
                {
                    label.Text = "CANCELADO";
                }
            }

        }

        private void IncrementarBarraProgreso(ProgressBar progressBar, Label label, int idHilo)
        {
            //tengo que hacer esto porque forms no te deja ejecutar en hilos secundarios lo que se creo en el principal,
            //en esta caso las progress bar. No se van a poder ejecutar en hilo secundario a menos que haga esto.

            //esta propiedad nos dice si es necesario volver a invocar el metodo desde otro hilo o continuar suy ejecucion
            //cuando el invokerequired es true porque estoy en un hilo secundario tratando de invocar controles y entra al if.
            //se vuelve a llamar y el invoke va a dar falso y va a hacer lo que tenga que hacer en el hilo correcto.
            if (InvokeRequired)
            {
                //array con parametros que necesita el metodo, en este caso el mismo metodo, son 3.
                object[] parametros = new object[] { progressBar, label, idHilo };
                Action<ProgressBar, Label, int> delegado;// creo el delegado
                delegado = IncrementarBarraProgreso; // asocio el delegado con el metodo, este mismo.
                Invoke(delegado, parametros); // lanzo el evento. si adelante del invoke no hay nada es porque es del propio form.


                //si el metodo no llevara parametros, el array de objects no es necesario y al invoke solo le paso el delegado.
            }
            else
            {
                progressBar.Increment(3);
                label.Text = $"Hilo nro: {idHilo} - {progressBar.Value}%";
            }

        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMostrar.Text, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancellationTokenSource.Cancel();//no va a funcionar porque tengo que asociar el tokensource a algo. en este caso a los task de hilos.
        }

        private void BtnVerInfo_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            //creo hila de task y las recorro e imprimo la informacion de cada progress bar / tarea.
            foreach (Task item in tasks)
            {
                sb.AppendLine($"Hilo: {item.Id}");
                string mensaje = item.IsCompleted ? "Esta completado." : $"en estado: {item.Status}"; 
                sb.AppendLine(mensaje);
                sb.AppendLine($"");
            }

            MessageBox.Show(sb.ToString(),"Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private async void btnReiniciar_Click(object sender, EventArgs e)
        {
            CancellationTokenSource.Cancel();

            while(!tasks.All(h => h.IsCompleted))//si no estan completos los hilos, al apretar reiniciar pasa lo de abajo.
            {
                await Task.Delay(1000); // al ser un metodo async(asincronico) el programa no se clava esperando una respuesta y sigue.
            }

            IniciarHilos(); //vuelvo a iniciar los hilos despues de 1 seg del delay.
        }
    }

}


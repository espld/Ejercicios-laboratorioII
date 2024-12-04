
select * from PROVEEDORES
select * from PRODUCTOS
select * from ENVIOS


---Obtener los detalles completos de todos los productos, ordenados alfabéticamente.
SELECT * FROM PRODUCTOS ORDER BY NOMBRE ASC;

---Obtener los detalles completos de todos los proveedores de ‘Quilmes’.
SELECT * FROM PROVEEDORES P WHERE P.LOCALIDAD = 'quilmes';

---Obtener todos los envíos en los cuales la cantidad este entre 200 y 300 inclusive.
SELECT * FROM ENVIOS E WHERE E.CANTIDAD >= 200 AND E.CANTIDAD <= 300;

---Obtener la cantidad total de todos los productos enviados.
SELECT SUM(E.CANTIDAD) SUMA_CANTIDADES_VENDIDAS_PRODUCTO1 FROM ENVIOS E WHERE CODIGO_PRODUCTO = 1 
SELECT SUM(E.CANTIDAD) SUMA_CANTIDADES_VENDIDAS_PRODUCTO2 FROM ENVIOS E WHERE CODIGO_PRODUCTO = 2 
SELECT SUM(E.CANTIDAD) SUMA_CANTIDADES_VENDIDAS_PRODUCTO3 FROM ENVIOS E WHERE CODIGO_PRODUCTO = 3 

---Mostrar los nombres de proveedores y los nombres de los productos enviados.
select P.NOMBRE,PR.NOMBRE from ENVIOS E JOIN PROVEEDORES P ON E.NUMERO_PROVEEDOR = P.NUMERO_PROVEEDOR JOIN  PRODUCTOS PR ON E.CODIGO_PRODUCTO = PR.CODIGO_PRODUCTO;
SELECT P.NOMBRE,PR.NOMBRE FROM PROVEEDORES P, PRODUCTOS PR, ENVIOS E WHERE E.NUMERO_PROVEEDOR = P.NUMERO_PROVEEDOR AND E.CODIGO_PRODUCTO = PR.CODIGO_PRODUCTO

---Indicar el monto (cantidad * precio) de todos los envíos.
SELECT E.CANTIDAD * E.CODIGO_PRODUCTO AS MONTO FROM ENVIOS E

---Obtener la cantidad total del producto 1 enviado por el proveedor 102.
SELECT E.CANTIDAD * E.CODIGO_PRODUCTO AS MONTO FROM ENVIOS E WHERE E.NUMERO_PROVEEDOR = 102 AND E.CODIGO_PRODUCTO = 1

---Agregar el producto numero 4, llamado ‘Chocolate’, de tamaño chico y con un precio de 25,35.
INSERT INTO PRODUCTOS (CODIGO_PRODUCTO,NOMBRE,PRECIO,DIMENSIONES) VALUES(4,'Chocolate',23.35,'Chico')
INSERT INTO PRODUCTOS VALUES(4,'Chocolate',23.35,'Chico')

---Insertar un nuevo proveedor (únicamente con los campos obligatorios).
INSERT INTO PROVEEDORES (NUMERO_PROVEEDOR) VALUES (103)

---Insertar un nuevo proveedor (107), donde el nombre y la localidad son ‘Rosales’ y ‘La Plata’.
INSERT INTO PROVEEDORES (NUMERO_PROVEEDOR,NOMBRE,LOCALIDAD) VALUES (107,'Rosales','La Plata')

--Cambiar los precios de los productos de tamaño ‘grande’ a 97,50.
UPDATE PRODUCTOS set PRECIO = 97.50 WHERE DIMENSIONES = 'Grande'

DELETE PRODUCTOS WHERE PRODUCTOS.NOMBRE = 'Caramelos';






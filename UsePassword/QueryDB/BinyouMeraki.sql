create database BimyouMeraki
go

use BimyouMeraki
go

--USE AdventureWorks2012;  
--GO  
--SELECT name, database_id, create_date  
--FROM sys.databases ;  
--GO  

--drop database BimyouMeraki
go
-----------------------------------------------------------------------------------------------------------------

create procedure busNombre(
                           @Nombre_Ci varchar(40)
						  )
as

SELECT @Nombre_Ci = RTRIM(@Nombre_Ci) + '%'; 
select Nombre_Ci from Clientes where Nombre_Ci like @Nombre_Ci
go

create procedure consCliente(
										@Name_C varchar(40)
									)
as
select * from Clientes where Nombre_Ci = @Name_C
go

create procedure BuscarCP(
                       @cp int
                         )
as
select asentamiento from sepomex where cp = @cp
go

--exec BuscarCP 20010

---exec BuscarUCP '49660'

--select * from sepomex 

create procedure BuscarUCP(
                          @cp int,
						  @asentamiento varchar(70)
						  )
as
select estado from sepomex where cp= @cp and asentamiento like @asentamiento 
go

--exec BuscarUCP 20000,'Zona Centro'
--select @Nombre_EM = RTRIM(@Nombre_EM) + '%';
--select Nombre_EM from Empleado where  Nombre_EM like @Nombre_EM
--go

---procedimiento de buscar por nombre

create procedure buscarNombreEmpleado(
                               @Nombre_EM varchar(20)
                               )
as
select * from Empleado where Nombre_EM= @Nombre_EM
go


--procedimieto de buscar un elemento por nombre 

create procedure buscarNombre3(
                          @Nombre_EM varchar(20)
                              )
as
select @Nombre_EM = RTRIM(@Nombre_EM) + '%';
select Nombre_EM from Empleado where  Nombre_EM like @Nombre_EM
go


create table Empleado(
						id_empleado int IDENTITY primary key not null,
						Calle_E varchar(40) not null,
						Colonia_E varchar(40) not null,
						Numero_E int not null,
						Nombre_EM varchar(40) not null,
						AP_E varchar(40) not null,
						AM_E varchar(40) not null,
						Edad int not null,						
						Fecha_ingreso varchar(20) not null,
						Telefono_E varchar(30) not null
						)
go

create procedure insertarEmpleado(
									@Calle_E varchar(40),
									@Colonia_E varchar(40),
									@Numero_E int,
									@Nombre_EM varchar(40),
									@AP_E varchar(40),
									@AM_E varchar(40),
									@Edad int,
									@Fecha_ingreso varchar(20),
									@Telefono_E varchar(30)
								)
as
insert into Empleado values(
								@Calle_E,
								@Colonia_E,
								@Numero_E,
								@Nombre_EM,
								@AP_E,
								@AM_E,
								@Edad,
								@Fecha_ingreso,
								@Telefono_E
						)
go

create procedure actualizarEmpleado(
										@id_empleado int,
										@Calle_E varchar(40),
										@Colonia_E varchar(40),
										@Numero_E int,
										@Nombre_EM varchar(40),
										@AP_E varchar(40),
										@AM_E varchar(40),
										@Edad int,
										@Fecha_ingreso varchar(20),
										@Telefono_E varchar(30)
								)
as
Update Empleado set
					Calle_E = @Calle_E,
					Colonia_E = @Colonia_E,
					Numero_E = @Numero_E,
					Nombre_EM = @Nombre_EM,
					AP_E = @AP_E,
					AM_E = @AM_E,
					Edad = @Edad,
					Fecha_ingreso = @Fecha_ingreso,
					Telefono_E = @Telefono_E
where id_empleado = @id_empleado
go

create procedure consultarEmpleado(
									@id_empleado int
									)
as
select * from Empleado where id_empleado = @id_empleado
go

create procedure eliminarEmpleado(
									@id_empleado int
									)
as
delete DV from Datos_venta DV INNER JOIN Venta V on  V.id_empleado = @id_empleado where V.id_venta = DV.id_venta
delete from Venta where id_empleado = @id_empleado
delete from Empleado where id_empleado = @id_empleado
go

/*
exec insertarEmpleado 'Barcelona','Mes que un club',69,'Ernesto','Baltazar','Torres',20,'01/03/2018','3411407683'
exec insertarEmpleado 'Bayern  Munich','Mia San Mia',63,'Miguel','Jacobo','Jacobo',21,'02/03/2018','3411518106'
exec insertarEmpleado 'Pokemon','Kanto',10,'Javier','Juarez','Villalvazo',21,'03/03/2018','3411260107'
exec insertarEmpleado 'Manchester City','Superbia in Proelio',78,'Manuel','Mejia','Martinez',20,'04/03/2018','3411240855'

exec actualizarEmpleado 4,'Manchester City','Superbia in Proelio',78,'Manuel','Mejia','Martinez',25,'05/03/2018','3411240855'
exec eliminarEmpleado 5
exec consultarEmpleado  3
go
*/
-----------------------------------------------------------------------------------------------------------------

create table dinero(
dinero float 

)
go
--select * from dinero
--go

create procedure insertardinero(
@dinero float
)
as
insert into dinero values(
@dinero
)
go
--execute insertardinero 500.00

create procedure actualizardinero(
@dinero float
)
as
Update dinero set 
					dinero = @dinero
					go
----------------------------------------------------------------------------------

create table Clientes(
						id_cliente int IDENTITY primary key not null,
						Nombre_Ci varchar(40) not null,
						AP_C varchar(40) not null,
						AM_C varchar(40) not null,
						Calle_C varchar(40) not null,
						Colonia_C varchar(40) not null,
						Numero_C int not null,
						Telefono_C varchar(30) not null,
						Fecha_Registro varchar(20) not null
						)
go

create procedure insertarCliente(
									@Nombre_Ci varchar(40),
									@AP_C varchar(40),
									@AM_C varchar(40),
									@Calle_C varchar(40),
									@Colonia_C varchar(40),
									@Numero_C int,
									@Telefono_C varchar(30),
									@Fecha_Registro varchar(20)
								)
as
insert into Clientes values(
								@Nombre_Ci,
								@AP_C,
								@AM_C,
								@Calle_C,
								@Colonia_C,
								@Numero_C,
								@Telefono_C,
								@Fecha_Registro
							)
go

create procedure actualizarCliente(
									@id_cliente int,
									@Nombre_Ci varchar(40),
									@AP_C varchar(40),
									@AM_C varchar(40),
									@Calle_C varchar(40),
									@Colonia_C varchar(40),
									@Numero_C int,
									@Telefono_C varchar(30),
									@Fecha_Registro varchar(20)									
									)
as
Update Clientes set 
					Nombre_Ci = @Nombre_Ci,
					AP_C = @AP_C,
					AM_C = @AM_C,
					Calle_C = @Calle_C,
					Colonia_C = @Colonia_C,
					Numero_C = @Numero_C,
					Telefono_C = @Telefono_C,
					Fecha_Registro = @Fecha_Registro 
where id_cliente = @id_cliente
go

create procedure consultarCliente(
									@id_cliente int
									)
as
select * from Clientes where id_cliente = @id_cliente
go

create procedure eliminarCliente(
									@id_cliente int
									)
as
delete DV from Datos_venta DV INNER JOIN Venta V on  V.id_cliente = @id_cliente where V.id_venta = DV.id_venta
delete from Venta where id_cliente = @id_cliente
delete from Clientes where id_cliente = @id_cliente
go

----      Modulo Cliente


create procedure BuscarCP(
                       @cp int
                         )
as
select asentamiento from sepomex where cp = @cp
go


--procedimiento buscar codigo postal ESTADO

create procedure BuscarUCP(
                          @cp int,
						  @asentamiento varchar (70)
						  )
as
select estado from sepomex where cp= @cp and asentamiento like @asentamiento 
go


----Buscar por nombre Cliente -------------

create procedure ConsultarNombreCliente(
                                  @Nombre_Ci varchar(20)
                                 )
as
select * from Clientes where Nombre_Ci= @Nombre_Ci
go

-----procedimiento para buscar por letra Cliente

create procedure ConsultarNombreCliente2(
                          @Nombre_Ci varchar(20)
                              )
as
select @Nombre_Ci = RTRIM(@Nombre_Ci) + '%';
select Nombre_Ci from Clientes where  Nombre_Ci like @Nombre_Ci
go

/*
exec insertarCliente 'Elon','Musk','','California','Estados Unidos',28,'518-3752','01/03/2018'
exec insertarCliente 'Steve','Jobs','','Silicon Valley','Mountain View',24,'692-7753','02/03/2018'
exec insertarCliente 'Mark','Zuckerberg','','California','Estados Unidos',14,'308-7837','03/03/2018'
exec insertarCliente 'William Henry','Gates','','Washington','Estados Unidos',28,'546-6542','04/03/2018'

exec actualizarCliente 4,'William Henry','Gates','','Washington','Estados Unidos',30,'546-6542','04/03/2018'
exec eliminarCliente 2
exec consultarCliente 2
go
*/

------------------------------------------------------------------------------------------------------------------

create table Proveedor(
						id_proveedor int IDENTITY primary key not null,
						Nombre_pro varchar(40) not null,						
						Telefono_pro varchar(30) not null,
						Direccion_pro varchar(100) not null,
					)
go

create procedure insertarProveedor(
									@Nombre_pro varchar(40),
									@Telefono_pro varchar(30),
									@Direccion_pro varchar(100)
								)
as
insert into Proveedor values (
								@Nombre_pro,
								@Telefono_pro,
								@Direccion_pro
							)
go

create procedure actualizarProveedor(
										@id_proveedor int,
										@Nombre_pro varchar(40),
										@Telefono_pro varchar(30),
										@Direccion_pro varchar(100)
									)
as
Update Proveedor set
					Nombre_pro = @Nombre_pro,
					Telefono_pro = @Telefono_pro,
					Direccion_pro = @Direccion_pro
where id_proveedor = @id_proveedor
go

create procedure consultarProveedor(
									@id_proveedor int
								)
as
select * from Proveedor where id_proveedor = @id_proveedor
go

create procedure eliminarProveedor(
									@id_proveedor int
								)
as
delete DC from Datos_Compra DC INNER JOIN Compra C on  C.id_proveedor = @id_proveedor where C.id_Compra = DC.id_Compra
delete from Compra where id_proveedor = @id_proveedor
delete from Proveedor where id_proveedor = @id_proveedor
go

----------------------------- Modulo Proveedor-------------------------
create procedure ConsultarNombrePro(
                                    @Nombre_pro varchar(40)
                                   )
as
select * from Proveedor where Nombre_pro= @Nombre_pro
go

--procedimiento buscar Proveedor por letra

create procedure ConsultarNombrePro2(
                                    @Nombre_pro varchar(40)
                                    )
									as
select @Nombre_pro = RTRIM(@Nombre_pro) + '%';
select Nombre_pro from Proveedor where  Nombre_pro like @Nombre_pro
go

/*
exec insertarProveedor 'HERDEZ','358-5506','Mexico'
exec insertarProveedor 'Coca-Cola FEMSA','704-4400','Mexico'
exec insertarProveedor 'Grupo Bimbo','910-2030','Mexico'
exec insertarProveedor 'Grupo Lala','112-0616','Mexico'

exec actualizarProveedor 4,'Grupo Lala','112-0616','Mexico DF'
exec eliminarProveedor 4
exec consultarProveedor 4
*/go

-----------------------------------------------------------------------------------------------------------------

create table Producto(
						id_producto varchar(20) primary key not null,
						Nombre_P varchar(40) not null,
						Tipo_P varchar(40) not null,
						StockMax int not null,
						StockMin int not null,
						id_proveedor int,
						Cantidad_P int,						
						Precio_Pro float,
						Precio_Tienda float,
						foreign key(id_proveedor) references Proveedor(id_proveedor)
					)
go


create procedure actualizarinventario(
									@id_producto int,
									@Cantidad_P int,
									@Precio_Pro float,
									@precio_Tienda float
								)
as
Update Producto set 
					Cantidad_P = @Cantidad_P,
					Precio_Pro = @Precio_Pro ,
					precio_Tienda = @precio_Tienda 
where id_producto = @id_producto

go


create procedure actualizarinventarioventa(
									@id_producto int,
									@Cantidad_P int,
									@precio_Tienda float
								)
as
Update Producto set 
					Cantidad_P = @Cantidad_P,
					precio_Tienda = @precio_Tienda 
where id_producto = @id_producto
go



create procedure insertarProducto(
									@id_producto varchar(20),
									@Nombre_P varchar(40),
									@Tipo_P varchar(40),
									@StockMax int,
									@StockMin int,
									@id_proveedor int
								)
as
insert into Producto values(
								@id_producto,
								@Nombre_P,
								@Tipo_P,
								@StockMax,
								@StockMin,
								@id_proveedor,
								0,
								0,
								0
							)
go

create procedure actualizarProducto(
									@id_producto varchar(20),
									@Nombre_P varchar(40),
									@Tipo_P varchar(40),
									@StockMax int,
									@StockMin int,
									@id_proveedor int
								)
as
Update Producto set 
					Nombre_P = @Nombre_P,
					Tipo_P = @Tipo_P ,
					StockMax = @StockMax,
					StockMin = @StockMin,
					id_proveedor = @id_proveedor
where id_producto = @id_producto
go

create procedure busquedaproducto(
									@Nombre_P varchar(40)
								)
as
select id_producto,Nombre_P, precio_Tienda,Cantidad_P from Producto where Nombre_P like '%' + @Nombre_P + '%'

go



create procedure busquedaproductocompra(
									@Nombre_P varchar(40),
									@proveedor int
								)
as
select id_producto,Nombre_P, precio_Tienda,Cantidad_P from Producto where Nombre_P like '%' + @Nombre_P + '%' and id_proveedor= @proveedor

go

create procedure consultarProducto(
									@id_producto Varchar(20)
								)
as
select * from Producto where id_producto =  @id_producto
go

create procedure consultarProductoByName(
										@Name varchar(40)
									)
as
SELECT @Name = RTRIM(@Name) + '%'; 
select Nombre_P from Producto where Nombre_P like @Name
go

--exec consultarProductoByName 'f'
--go

create procedure consultAllProductByName(
										@Name varchar(40)
									)
as
select * from Producto where Nombre_P = @Name
go

--exec consultAllProductByName 'Leche light'
--go

create procedure consultTypesOfProduct(
										@type varchar(40)
									)
as
SELECT @type = RTRIM(@type) + '%'; 
select distinct Tipo_P from Producto where Tipo_P like @type
go

--exec consultTypesOfProduct 'l'
--go

create procedure consultProductByProv(
										@IdProv int
									)
as
select * from Producto where id_proveedor = @IdProv
go


create procedure eliminarProducto(
									@id_producto varchar(20)
								)
as
delete from Datos_venta where id_producto = @id_producto
delete from Datos_Compra where id_producto = @id_producto
delete from Producto where id_producto =  @id_producto
go
/*
exec insertarProducto '1','Galletas','BOTANAS',100,10,1
exec insertarProducto '2','Leche light','LÁCTEOS',100,10,2
exec insertarProducto '3','Barras alimenticias','BOTANAS',100,10,3
exec insertarProducto '4','Energetizantes','BEBIDAS',100,10,4

exec actualizarProducto '1','Galletas','BOTANAS',100,10,1
exec eliminarProducto 1
exec consultarProducto 4
*/go

------------------------------------------------------------------------------------------------------------------

create table Venta(
					id_venta int IDENTITY primary key not null,
					Fecha_vent varchar(20) not null,
					Total_venta float not null				 
					)
go

create procedure insertarVenta(
								@Fecha_vent varchar(20),
								@Total_venta float
							)
as
insert into Venta values(
							@Fecha_vent,
							@Total_venta
						)
go

create procedure actualizarVenta(
									@id_venta int,
									@Fecha_vent varchar(20),
									@Total_venta float
								)
as
Update Venta set 
				Fecha_vent = @Fecha_vent,
				Total_venta = @Total_venta
where id_venta = @id_venta
go

create procedure consultarVenta(
									@id_venta int
								)
as
select * from Venta where id_venta = @id_venta
go

create procedure eliminarVenta(
								@id_venta int
							)
as
delete from Datos_venta where id_venta = @id_venta
delete from Venta where id_venta = @id_venta
go

/*
exec insertarVenta '07/05/2018',500
exec insertarVenta '07/05/2018',400
exec insertarVenta '07/05/2018',300
exec insertarVenta '07/05/2018',200
 select * from venta

exec actualizarVenta 2,3,2,'19/06/2018',300
exec eliminarVenta 4
exec consultarVenta 5
*/
go

------------------------------------------------------------------------------------------------------------------

create table Datos_venta(
						 id_venta int not null,
						 id_producto varchar(20) not null,
						 Nombre_P varchar(40) not null,							 
						 Cantidad_producto int not null,
						 precio_Tienda float,
						 precio_final float,						
						 foreign key(id_producto) references Producto(id_producto),
						 foreign key(id_venta) references venta(id_venta),
						 primary key(id_venta,id_producto)
						 )
go

create procedure insertarDatos_venta(
										@id_venta int,
										@id_producto varchar(20),
										@Nombre_P varchar(40),
										@Cantidad_producto int,
										@precio_Tienda float,
										@precio_final float
									)
as
insert into Datos_venta values(
								@id_venta,
								@id_producto,
								@Nombre_P,
								@Cantidad_producto,
								@precio_Tienda,
								@precio_final 
							)
go

create procedure actualizarDatos_venta(
										@id_venta int,
										@id_producto varchar(20),
										@Cantidad_producto int
										)
as
Update Datos_venta set
						Cantidad_producto = @Cantidad_producto
where ( id_venta= @id_venta) and (id_producto = @id_producto)
go

create procedure consultarDatos_venta(
										@id_venta int,
										@id_producto varchar(20)
									)
as
select * from Datos_venta where (id_venta = @id_venta) and (id_producto = @id_producto)
go

create procedure eliminarDatos_venta(
										@id_venta int,
										@id_producto varchar(20)
									)
as
delete from Datos_venta where (id_venta = @id_venta) and (id_producto = @id_producto)
go

/*
exec insertarDatos_venta 1,'4','Galletas',500,50,55
exec insertarDatos_venta 2,'3','Leche light',500,50,55
exec insertarDatos_venta 3,'2','Barras alimenticias',500,50,55
exec insertarDatos_venta 4,'1','Energetizantes',500,50,55

exec actualizarDatos_venta 5,4,6
exec eliminarDatos_venta 5,4
exec consultarDatos_venta 5,4
*/
go

----------------------------------------------------------------------------------------------------------------

create table Compra(
					id_Compra int IDENTITY primary key not null,
					id_proveedor int not null,
					Fecha_compra varchar(20) not null,
					Precio_total float not null,
					foreign key(id_proveedor) references Proveedor(id_proveedor)					
					)
go

create procedure insertarCompra(
								@id_proveedor int,
								@Fecha_compra varchar(20),
								@Precio_total float
							)
as
insert into Compra values(
							@id_proveedor,
							@Fecha_compra,
							@Precio_total
						)
go

create procedure actualizarCompra(
									@id_Compra int,
									@id_proveedor int,
									@Fecha_compra varchar(20),
									@Precio_total float
								)
as
Update Compra set 
					id_proveedor = @id_proveedor,
					Fecha_compra = @Fecha_compra,
					Precio_total = @Precio_total
where id_Compra = @id_Compra
go


create procedure consultar_Compra(
									@id_Compra int
								)
as
select * from Compra,Datos_Compra,Proveedor where Compra.id_Compra = @id_Compra
go



create procedure consultarCompra(
									@id_Compra int
								)
as
select * from Compra where id_Compra = @id_Compra
go

create procedure eliminarCompra(
								@id_Compra int
							)
as
delete from Datos_Compra where id_Compra = @id_Compra
delete from Compra where id_Compra = @id_Compra
go

/*
exec insertarCompra 4,'17/04/2018',1000
exec insertarCompra 3,'18/05/2018',2000
exec insertarCompra 2,'19/06/2018',3000
exec insertarCompra 1,'20/07/2018',4000

exec actualizarCompra 4,4,'17/04/2018',6000
exec eliminarCompra 4
exec consultarCompra 5
*/
go

------------------------------------------------------------------------------------------------------------------

create table Datos_Compra(
							id_Compra int not null,
							id_producto varchar(20) not null,
							Nombre_P varchar(40) not null,
							Cantidad_p int not null,
							Precio_Pro float not null,
						    precio_Tienda float not null,
							importe_total float not null,							
							foreign key(id_Compra) references Compra(id_Compra),
							foreign key(id_producto) references Producto(id_producto),
							primary KEY(id_Compra,id_producto)
							)
go

create procedure insertarDatos_Compra(
										@id_Compra int,
										@id_producto varchar(20),
										@Nombre_P varchar(40),
										@Cantidad_p int,
										@precio_Pro float,
										@precio_Tienda float,
										@importe_total float
									)
as
insert into Datos_Compra values(
								@id_Compra,
								@id_producto,
								@Nombre_P,
								@Cantidad_p,
								@precio_Pro,
								@precio_Tienda,
								@importe_total
							)
go

create procedure actualizarDatos_Compra(
										@id_Compra int,
										@id_producto varchar(20),
										@Nombre_P varchar (40),
										@Cantidad_p int,
										@precio_Pro float,
										@precio_Tienda float,
										@importe_total float
									)
as
Update Datos_Compra set
						Cantidad_p = @Cantidad_p
where (id_Compra = @id_Compra) and (id_producto = @id_producto)
go

create procedure consultarDatos_Compra(
										@id_Compra int,
										@id_producto varchar(20),
										@Nombre_P varchar(40),
										@Cantidad_p int,
										@precio_Pro float,
										@precio_Tienda float,
										@importe_total float
									)
as
select * from Datos_Compra where (id_Compra = @id_Compra) and (id_producto = @id_producto)
go

create procedure eliminarDatos_Compra(
										@id_Compra int,
										@id_producto varchar(20)
									)
as
delete from Datos_Compra where (id_Compra = @id_Compra) and (id_producto = @id_producto)
go

/*
exec insertarDatos_Compra 1,'2','Leche light',4,20,25,25
exec insertarDatos_Compra 2,'1','Galletas',4,20,25,25
exec insertarDatos_Compra 3,'3','Barras alimenticias',4,20,25,25
exec insertarDatos_Compra 4,'4','Energetizantes',4,20,25,25

exec actualizarDatos_Compra 5,4,600
exec eliminarDatos_Compra 5,4
exec consultarDatos_Compra 5,4
*/
go

------------------------------------------------------------------------------------------------------------------

--SELECT IDENT_CURRENT ('Compra');

--select * from Compra

create procedure RestoreDB(
							@Rute varchar(1000)
						)
as
RESTORE DATABASE BimyouMeraki FROM DISK = @Rute
go

create procedure BackUpDB(
							@Route varchar(1000)
						)
as
BACKUP DATABASE BimyouMeraki TO DISK = @Route
go

--------------------------AREA DE REPORTES---------------------------------------------------------------
--BACKUP DATABASE CorreosMexico TO DISK = 'D:\temp\Mexico.bak'

--exec BackUpDB 'D:\temp\rosario.bak'
--go

create procedure ByGroups(
							@tipo varchar(40)
						)
as
select Nombre_P,Precio_Pro,Cantidad_P,Precio_Pro*Cantidad_P as Total from Producto where Tipo_P = @tipo
go

--exec ByGroups 'BEBIDAS'
--go

create procedure ByDay(
						@fecha varchar(20)
					)
as
select distinct P.id_producto,P.Nombre_P,v.Fecha_vent,(select sum(DV.Cantidad_producto) from Datos_venta DV inner join Venta V on DV.id_venta = V.id_venta where DV.id_producto = P.id_producto and V.Fecha_vent like @fecha) as [Venta Por dia] from Producto P inner join Venta V on  V.Fecha_vent like @fecha
go

--exec ByDay '20/07/2018'
--go

create procedure ByMonth(
							@fecha varchar(20)
						)
as
select distinct P.id_producto,P.Nombre_P,v.Fecha_vent,(select sum(DV.Cantidad_producto) from Datos_venta DV inner join Venta V on DV.id_venta = V.id_venta where DV.id_producto = P.id_producto and V.Fecha_vent like @fecha) as [Venta Por Mes] from Producto P inner join Venta V on  V.Fecha_vent like @fecha
go

--exec ByMonth '%/04/2018'
--go

--drop procedure SaleByDate
create procedure SaleByDate(
								@StartDate varchar(20),
								@FinalDate varchar(20)
							)
as
select * from Venta where Fecha_vent like @StartDate and Fecha_vent like @FinalDate
--SELECT v.id_venta, c.Nombre_Ci, e.Nombre_EM, v.Fecha_vent, v.Total_venta FROM Empleado e INNER JOIN Venta v ON e.id_empleado = v. INNER JOIN Clientes c ON c.id_cliente = v.id_cliente WHERE v.Fecha_vent like @fecha
go

--exec SaleByDate '%20/07/2018'

--drop procedure BuyByDate
create procedure BuyByDate(
								@StartDate varchar(20),
								@FinalDate varchar(20)
							)
as
SELECT c.id_Compra, p.Nombre_pro, c.Fecha_compra, c.Precio_total FROM Proveedor P INNER JOIN Compra C ON P.id_proveedor = C.id_proveedor WHERE C.Fecha_compra LIKE @StartDate and C.Fecha_compra LIKE @FinalDate
go

--exec BuyByDate '%20/07/2018'
/*
select * from Empleado
select * from Clientes
select * from Proveedor
select * from Producto
select * from Venta
select * from Datos_venta
select * from Compra
select * from Datos_Compra
go*/
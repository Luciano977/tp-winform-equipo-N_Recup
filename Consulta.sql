

select * from ARTICULOS
select * from MARCAS
select * from CATEGORIAS
update ARTICULOS set IdMarca = 2, IdCategoria=3 where id=6
select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS 
Marca, C.Descripcion as Categoria, A.Precio from ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.Id = M.Id AND A.Id = C.Id

select 
A.Codigo, 
A.Nombre, 
A.Descripcion, 
M.Descripcion AS Marca, 
C.Descripcion as Categoria, 
A.Precio 
from ARTICULOS A 
INNER JOIN MARCAS M ON A.IdMarca = M.Id
INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id;
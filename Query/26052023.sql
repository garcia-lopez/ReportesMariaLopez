Use DBLaCasaDelArte
go

SELECT Usuario.usuario_id as N'CÓDIGO', Rol.nombreRol as N'ROL',
                                                 Usuario.primer_nombre + N' ' + ISNULL(Usuario.segundo_nombre, '') + N' ' + 
                                                 Usuario.primer_apellido  + N' ' + 
                                                 ISNULL(Usuario.segundo_apellido, '') as N'NOMBRE COMPLETO',
                                                 Usuario.nombre_usuario as N'NOMBRE DE USUARIO',
                                                 Usuario.telefono as N'TELÉFONO',
                                                 convert(nvarchar(10),Usuario.fecha_nac, 103) as N'FECHA DE NACIMIENTO',
                                                 Usuario.cedula as N'CÉDULA'
                                                 FROM Usuario INNER JOIN Rol On Usuario.id_rol = Rol.id_rol
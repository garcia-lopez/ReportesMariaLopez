Use DBLaCasaDelArte
go

SELECT Usuario.usuario_id as N'C�DIGO', Rol.nombreRol as N'ROL',
                                                 Usuario.primer_nombre + N' ' + ISNULL(Usuario.segundo_nombre, '') + N' ' + 
                                                 Usuario.primer_apellido  + N' ' + 
                                                 ISNULL(Usuario.segundo_apellido, '') as N'NOMBRE COMPLETO',
                                                 Usuario.nombre_usuario as N'NOMBRE DE USUARIO',
                                                 Usuario.telefono as N'TEL�FONO',
                                                 convert(nvarchar(10),Usuario.fecha_nac, 103) as N'FECHA DE NACIMIENTO',
                                                 Usuario.cedula as N'C�DULA'
                                                 FROM Usuario INNER JOIN Rol On Usuario.id_rol = Rol.id_rol
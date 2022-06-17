# Alcancías Virtuales Inteligentes “appAlcanciaX”<br>
Se solicita al equipo de desarrollo, la construcción de un software de gestión para la información de 
alcancías virtuales inteligentes. El proyecto denominado para todos sus efectos como appAlcanciaX
permitirá al usuario servirse de las siguientes capacidades:
<br><br>
En el momento de su creación, la alcancía inteligente permite determinar el nombre de la divisa que 
se manejará. Con base en esta divisa, se restringe el ingreso de todo dinero que NO pertenezca a la 
misma. El sistema puede gestionar al mismo tiempo una o varias alcancías, sin embargo no es 
necesaria la pre-existencia de la alcancía para iniciar con el registro, actualización, eliminación y 
consulta de los ítems de dinero. Tampoco es necesaria la pre-existencia del dinero para registrar, 
actualizar y eliminar una alcancía que aunque vacía es totalmente válida.
<br><br>
De otra parte, se admiten dos tipos de ítems relacionados con el dinero: Monedas y Billetes. Es 
necesario aclarar que el dinero NO se genera al interior de la alcancía, en su lugar viene desde fuera 
mediante la transacción de ingreso o va hacia fuera mediante la transacción de retiro. Fuera de la 
alcancía como entidad encontramos al sistema.
<br><br>
Es posible ingresar un solo ítem de dinero o varios, siempre y cuando la denominación de cada ítem 
sea admitida por la alcancía; las denominaciones para billetes y monedas que aceptará la alcancía, 
se determinan en el momento de su creación. Sin embargo, estas denominaciones se pueden 
ajustar en cualquier momento siempre y cuando no afecten los saldos por denominación ni los 
conteos por denominación. También es posible el retiro de uno o varios ítems de dinero.
<br><br>
Ante cualquier transacción (retiro o ingreso) una alcancía realizará de forma automática, las 
actualizaciones siguientes: Saldo Total, Saldo Total en Monedas, Saldo Total en Billetes, Saldo Total 
Monedas por Denominación, Saldo Total en Billetes por Denominación, Conteo Total de Monedas, 
Conteo Total de Billetes, Conteo total de Monedas por Denominación y Conteo Total de Billetes por 
Denominación.
<br><br>
Además en el momento de la creación de una alcancía virtual inteligente se puede establecer la 
capacidad en monedas y la capacidad en billetes que máximo podrá contener, a menos que en 
cualquier instante se desee incrementar o disminuir estas capacidades siempre y cuando no afecten 
el estado al interior de los ítems de dinero (ej. Pasar de una capacidad mayor a una menor dejaría 
dinero por fuera de la alcancía con información inconsistente).
<br><br>
El dinero como ya se mencionó, nace fuera de la alcancía. Es el sistema quien lleva cuenta del dinero 
registrado allí. Cada moneda se especifica con un identificador de objeto (IDO) nombre de divisa, 
una denominación (valor) y un año de emisión; mientras que cada billete se especifica (además de 
lo atribuido a moneda) con mes y día de emisión. Nota: El billete usa al IDO como su número de 
serie.
<br><br>
También el sistema gestiona (además del registro): la actualización, eliminación e incluso ofrecerá 
algunos servicios de consulta para hallar un ítem de dinero determinado, usando como criterio de 
búsqueda al Identificador de Objeto (IDO). El sistema como ya se mencionó puede gestionar 
distintas alcancías donde de forma simultánea varios ahorradores ingresan o retiran dineros en 
ellas.
<br><br>
El ahorrador tendrá un usuario en el sistema y tomará posesión del dinero mediante un acto 
administrativo del encargado del sistema, es así que por ejemplo un ítem de dinero puede tener o 
no dueño. En caso de NO tener dueño, el dinero no puede ingresar a ninguna Alcancía, tampoco 
puede perder el dueño aquel dinero que ya está en la alcancía. En resumen cuando el dinero está 
dentro de la alcancía no puede modificarse o eliminarse su dueño bajo ninguna circunstancia; 
cuando esté fuera sí.
<br><br>
Los entregables de appAlcanciaX serán:
- Capa de Dominio.
- Capa de Presentación. 
- Capa de Persistencia. Cap 38 Larman.
- Unidad de Pruebas.
- Manual de Usuario. Doxygen.
- Arquitectura Documentada

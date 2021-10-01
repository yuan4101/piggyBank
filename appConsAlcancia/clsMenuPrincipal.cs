using appAlcancia.Dominio;
using libServices;

namespace appConsAlcancia
{
    class clsMenuPrincipal : clsMenu
    {
        protected override void Configurar()
        {
            atrItems.Add(" appAlcancia - MENU PRINCIPAL");
            atrItems.Add("Establecer Preferencias de la Alcancia...");
            atrItems.Add("Introducir Moneda.");
            atrItems.Add("Introducir Billete.");
            atrItems.Add("Extraer Moneda.");
            atrItems.Add("Extraer Billete.");
            atrItems.Add("Extractos.");
            atrItems.Add("Salir\n");
        }
        protected override void Procesar()
        {
            int varContador = 0;

            switch (atrOpcionElegida)
            {
                case 1: new clsSubMenuPreferenciasAlcancia(); break;

                case 2:
                    clsConsola.EscribirEncabezado(" EJECUTANDO: Insertar Moneda en Alcancia");
                    clsConsola.Escribir(" Ingrese un valor para Denominacion contemplado entre [");
                    for (int i = 0; i < clsSistema.getInstancia().darAlcancia().atrCantidadDenominacionMonedas; i++)
                        clsConsola.Escribir(clsSistema.getInstancia().darAlcancia().atrDenominacionesMoneda[i] + ",");
                    clsSistema.getInstancia().darAlcancia().asociarMonedaCon(new clsMoneda(clsConsola.Leer<int>("]: "), 2020));
                    clsConsola.EscribirEncabezado(" CONFIRMACION: La moneda ha sido ingresada exitosamente");
                    clsConsola.Pausa(" Presione una tecla para continuar...");
                    clsConsola.EscribirEncabezado(" AVISO: Impresion de Datos provenientes del Vector <Cantidad Monedas x Denominacion de >");
                    for (int i = 0; i < clsSistema.getInstancia().darAlcancia().atrCapacidadMonedas; i++)
                    {

                    }

                    break;

                case 3:  break;
                case 4:  break;
                case 5:  break;
                case 6:  break;
                case 7: clsConsola.EscribirLN(" Saliendo de la Alcancia!"); break;
                default:
                    clsConsola.EscribirEncabezado("ERROR: Opcion No Valida!");
                    clsConsola.Pausa(" Presione una tecla para continuar...");
                    break;
            }
        }
    }
}

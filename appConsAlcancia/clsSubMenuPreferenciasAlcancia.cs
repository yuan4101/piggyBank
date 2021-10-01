using appAlcancia.Dominio;
using libServices;

namespace appConsAlcancia
{
    class clsSubMenuPreferenciasAlcancia : clsMenuPrincipal
    {
        protected override void Configurar()
        {
            atrItems.Add(" MENU PREFERENCIAS DE ALCANCIA ");
            atrItems.Add("Establecer Capacidad.");
            atrItems.Add("Establecer Las Denominaciones Aceptadas.");
            atrItems.Add("Ver Preferencias y Estado de la Alcancia");
            atrItems.Add("Regresar al Menu Anterior...\n");
        }
        protected override void Procesar()
        {
            int varSaldo = 0;
            switch (atrOpcionElegida)
            {
                case 1:
                    clsConsola.EscribirEncabezado(" EJECUTANDO: CONFIGURAR LA CAPACIDAD PARA LA ALCANCIA");
                    clsSistema.getInstancia().asociarAlcanciaCon(new clsAlcancia(clsConsola.LeerEntre<int>(" Ingrese un valor entre [1..1000] para <Capacidad Monedas>: ", 1, 1000), clsConsola.LeerEntre<int>(" Ingrese un valor entre [1..1000] para <Capacidad Billetes>: ", 1, 1000)));
                    clsConsola.EscribirEncabezado(" CONFIRMACION: La Capacidad de la Alcancia se Establecio con Exito.");
                    clsConsola.Pausa(" Presione una tecla para continuar...");
                    break;

                case 2:
                    if (clsSistema.getInstancia().atrAlcancia == null)
                    {
                        clsConsola.EscribirEncabezado(" La Alcancia no se ha inicializado!");
                        clsConsola.Pausa(" Presione una tecla para continuar...");
                        break;
                    }
                    clsConsola.EscribirEncabezado(" EJECUTANDO: CONFIGURAR LAS DENOMINACIONES ACEPTADAS");

                    clsSistema.getInstancia().darAlcancia().atrCantidadDenominacionMonedas = clsConsola.LeerEntre<int>(" Ingrese un valor entre [1..6] para <Cantidad de Denominaciones Aceptadas para Moneda>: ", 1, 6);
                    for (int i = 0; i < clsSistema.getInstancia().darAlcancia().atrCantidadDenominacionMonedas; i++)
                        clsSistema.getInstancia().darAlcancia().atrDenominacionesMoneda.Add(clsConsola.LeerEntre<int>(" Ingrese un valor entre [1..1000] para <DenominacionesMoneda[" + i +"]>: ", 1, 1000));

                    clsSistema.getInstancia().darAlcancia().atrCantidadDenominacionBilletes = clsConsola.LeerEntre<int>("\n Ingrese un valor entre [1..6] para <Cantidad de Denominaciones Aceptadas para Billete>: ", 1, 6);
                    for (int i = 0; i < clsSistema.getInstancia().darAlcancia().atrCantidadDenominacionBilletes; i++)
                        clsSistema.getInstancia().darAlcancia().atrDenominacionesBillete.Add(clsConsola.LeerEntre<int>(" Ingrese un valor entre [1..100000] para <DenominacionesBillete[" + i + "]>: ", 1, 100000));

                    clsConsola.EscribirEncabezado(" CONFIRMACION: La Cantidad de Denominaciones Aceptadas por la Alcancia se Establecio con Exito.");
                    clsConsola.Pausa(" Presione una tecla para continuar...");
                    break;

                case 3:
                    if (clsSistema.getInstancia().atrAlcancia == null)
                    {
                        clsConsola.EscribirEncabezado(" La Alcancia no se ha inicializado!");
                        clsConsola.Pausa(" Presione una tecla para continuar...");
                        break;
                    }
                    clsConsola.EscribirEncabezado(" EJECUTANDO: VER PREFERENCIAS Y ESTADO DE LA ALCANCIA");
                    clsConsola.EscribirLN(" El valor de <Capacidad Monedas> es: " + clsSistema.getInstancia().darAlcancia().atrCapacidadMonedas);
                    clsConsola.EscribirLN(" El valor de <Capacidad Billetes> es: " + clsSistema.getInstancia().darAlcancia().atrCapacidadBilletes);
                    clsConsola.EscribirLN(" El valor de <Numero total de Monedas> es: " + clsSistema.getInstancia().darAlcancia().darMonedas().Count);
                    clsConsola.EscribirLN(" El valor de <Numero total de Billetes> es: " + clsSistema.getInstancia().darAlcancia().darBilletes().Count);

                    for (int i = 0; i < clsSistema.getInstancia().darAlcancia().darMonedas().Count; i++)
                        varSaldo = varSaldo + clsSistema.getInstancia().darAlcancia().darMonedas()[i].darDenominacion();
                    clsConsola.EscribirLN(" El valor de <Saldo Total de Monedas> es: " + varSaldo);

                    for (int i = 0; i < clsSistema.getInstancia().darAlcancia().darBilletes().Count; i++)
                        varSaldo = varSaldo + clsSistema.getInstancia().darAlcancia().darBilletes()[i].darDenominacion();
                    clsConsola.EscribirLN(" El valor de <Saldo Total de Billetes> es: " + varSaldo);

                    clsConsola.EscribirLN(" El valor de <Indice (%) de Llenado de Alcancia> es: " + (((clsSistema.getInstancia().darAlcancia().darMonedas().Count + clsSistema.getInstancia().darAlcancia().darBilletes().Count) * 100) / (clsSistema.getInstancia().darAlcancia().atrCapacidadMonedas + clsSistema.getInstancia().darAlcancia().atrCapacidadBilletes)));

                    clsConsola.EscribirLN(" El valor de <Denominaciones de Moneda Aceptadas> es: " + clsSistema.getInstancia().darAlcancia().atrCantidadDenominacionMonedas);
                    clsConsola.EscribirLN(" El valor de <Denominaciones de Moneda Aceptadas> es: " + clsSistema.getInstancia().darAlcancia().atrCantidadDenominacionBilletes);

                    clsConsola.EscribirEncabezado(" AVISO: Impresion de Datos provenientes del Vector <DenominacionMonedas>");
                    for (int i = 0; i < clsSistema.getInstancia().darAlcancia().atrCantidadDenominacionMonedas; i++)
                        clsConsola.EscribirLN(" DenominacionMonedas[" + i + "] = " + clsSistema.getInstancia().darAlcancia().atrDenominacionesMoneda[i]);

                    clsConsola.EscribirEncabezado(" AVISO: Impresion de Datos provenientes del Vector <DenominacionBilletes>");
                    for (int i = 0; i < clsSistema.getInstancia().darAlcancia().atrCantidadDenominacionBilletes; i++)
                        clsConsola.EscribirLN(" DenominacionBilletes[" + i + "] = " + clsSistema.getInstancia().darAlcancia().atrDenominacionesBillete[i]);

                    clsConsola.Pausa(" Presione una tecla para continuar...");
                    break;

                case 4: clsConsola.EscribirLN(" Regresando al Menu Principal!"); break;

                default:
                    clsConsola.EscribirEncabezado("ERROR: Opcion No Valida!");
                    clsConsola.Pausa(" Presione una tecla para continuar...");
                    break;
            }
        }
    }
}

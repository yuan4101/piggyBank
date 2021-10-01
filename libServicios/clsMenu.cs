using System.Collections.Generic;

namespace libServices
{
    public class clsMenu
    {
        #region Atributos
        private int atrOpcionSalir = -1;
        protected int atrOpcionElegida = -1;
        protected List<string> atrItems = new List<string>();
        #endregion
        #region Metodos
        public clsMenu()
        {
            Iterar();
        }
        private void Imprimir()
        {
            clsConsola.limpiarScreen();
            clsConsola.EscribirEncabezado(atrItems[0]);
            for (int i = 1; i < atrItems.Count; i++)
                clsConsola.EscribirLN(" " + i + ". " + atrItems[i]);
        }
        protected virtual void Configurar() { }
        protected virtual void Procesar() { }
        private void Iterar()
        {
            Configurar();
            atrOpcionSalir = atrItems.Count - 1;
            do
            {
                Imprimir();
                atrOpcionElegida = clsConsola.Leer<int>(" Seleccione una opcion del menu: ");
                clsConsola.limpiarScreen();
                Procesar();
            } while (atrOpcionElegida != atrOpcionSalir);
            clsConsola.Pausa("Presione una tecla para continuar...");
        }
        #endregion
    }
}
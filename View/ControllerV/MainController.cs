using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.ControllerV
{
    public class MainController
    {
       
        internal void OpenUCKorisnici(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCKorisnici(new KorisniciController()));
        }

        internal void OpenUCRezervacije(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCRezervacije(new RezervacijeController()));
        }

        internal void OpenUCTermini(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCTermini(new TerminiController()));
        }

        internal void OpenUCUnosRezervacija(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUnosRezervacija(new UnosRezervacijaController()));
        }

        internal void OpenUCUnosKorisnika(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUnosKorisnika(new UnosKorisnikaController()));
        }

        internal void OpenUCUnosTermina(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUnosTermina(new UnosTerminaController()));
        }

        internal void OpenUCUsluge(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUsluge(new UslugeController()));
        }

    }
}

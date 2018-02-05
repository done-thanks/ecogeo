using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using GoC.WebTemplate;

namespace LWBSF_Ramp2.Controllers
{
    public class AppController : GoC.WebTemplate.WebTemplateBaseController
    {
        private void setFrench()
        {
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr.html", "Accueil", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/services/environnement.html", "Environnement et ressources naturelles", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/services/environnement/conservation.html", "Conservation et protection de l'environnement", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/services/environnement/conservation/financement.html", "Financement pour l'environment", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/environnement-changement-climatique/services/financement-environnement.html", "Programmes de financement d'Environnement et Changement climatique Canada", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/fr/environnement-changement-climatique/services/financement-environnement/programme-communautaire-ecoaction.html", "Programme de financement communautaire ÉcoAction", ""));

            this.WebTemplateCore.HeaderTitle = "Programme de financement communautaire ÉcoAction ";
            this.WebTemplateCore.ApplicationTitle.Text = "Programme de financement communautaire ÉcoAction";
            this.WebTemplateCore.ContactLink = new Link("https://www.canada.ca/fr/contact.html", "Contact Us");
            this.WebTemplateCore.TermsConditionsLinkURL = "https://www.canada.ca/fr/transparence/avis.html";
            this.WebTemplateCore.PrivacyLinkURL = "https://www.canada.ca/fr/transparence/confidentialite.html";
        }

        private void setEnglish()
        {
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en.html", "Home", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/services/environment.html", "Environment and natural resources", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/services/environment/conservation.html", "Environmental conservation and protection", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/services/environment/conservation/funding.html", "Environmental funding", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/environment-climate-change/services/environmental-funding.html", "Environment and Climate Change Canada funding programs", ""));
            this.WebTemplateCore.Breadcrumbs.Add(new Breadcrumb("https://www.canada.ca/en/environment-climate-change/services/environmental-funding/ecoaction-community-program.html", "EcoAction Community Funding Program", ""));

            this.WebTemplateCore.HeaderTitle = "EcoAction Community Funding Program ";
            this.WebTemplateCore.ApplicationTitle.Text = "EcoAction Community Funding Program";
            this.WebTemplateCore.ContactLink = new Link("https://www.canada.ca/en/contact", "Contact Us");
            this.WebTemplateCore.TermsConditionsLinkURL = "https://www.canada.ca/en/transparency/terms.html";
            this.WebTemplateCore.PrivacyLinkURL = "https://www.canada.ca/en/transparency/privacy.html";
        }

        public ActionResult index(string lang)
        {
            if (this.WebTemplateCore.TwoLetterCultureLanguage == "fr")
            {
                setFrench();
            }
            else
            {
                setEnglish();
            }

            return View();
        }
	}
}
using System;
using System.Collections.Generic;
using GoC.WebTemplate;


public partial class Ecogeo : GoC.WebTemplate.BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.WebTemplateMaster.WebTemplateCore.HeaderTitle = "EcoGeo";
            this.WebTemplateMaster.WebTemplateCore.ApplicationTitle.Text = "EcoGeo";
            this.WebTemplateMaster.WebTemplateCore.ApplicationTitle.URL = "http://canada.ca";
            this.WebTemplateMaster.WebTemplateCore.ShowPreContent = false;
            this.WebTemplateMaster.WebTemplateCore.ShowSecure = true;
            // this.WebTemplateMaster.WebTemplateCore.ShowSearch = true;
            // this.WebTemplateMaster.WebTemplateCore.DateModified = DateTime.Now;
        }
    }
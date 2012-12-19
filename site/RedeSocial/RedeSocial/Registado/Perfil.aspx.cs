﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rede;

namespace RedeSocial.Registado
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            MembershipUser currentLoggedInUser = Membership.GetUser();
            if (currentLoggedInUser != null)
            {
                string id = Convert.ToString(currentLoggedInUser.ProviderUserKey);
                Rede.Perfil prof = Rede.Perfil.LoadByUserId(id);
                if (prof != null)
                {

                    TextNome.Text = prof.Name;
                    TextMorada.Text = prof.Morada;
                    TextFace.Text = prof.FaceBook;
                    TextData.Text = prof.DataNascimento.ToShortDateString();
                    TextLinkedin.Text = prof.Linkedin;
                    TextTlm.Text = prof.Telemovel.ToString();
                    TextAvatar.Text = prof.avatar.Designacao;
                }
                else
                {
                    id = Convert.ToString(currentLoggedInUser.ProviderUserKey);
                    prof = new Rede.Perfil(id);
                    prof.Save();
                }
            }

        }

        
        protected void Button3_Click(object sender, EventArgs e)
        {
            TextNome.Text = "";
            TextMorada.Text = "";
            TextData.Text = "";
            TextLinkedin.Text = "";
            TextFace.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MembershipUser currentLoggedInUser = Membership.GetUser();

            string id = Convert.ToString(currentLoggedInUser.ProviderUserKey);
            Rede.Perfil prof = Rede.Perfil.LoadByUserId(id);
            prof.Nick = TextNick.Text;
            prof.Name = TextNome.Text;
            prof.Morada = TextMorada.Text;
            prof.FaceBook = TextFace.Text;
            prof.DataNascimento = Convert.ToDateTime(TextData.Text);
            prof.Linkedin = TextLinkedin.Text;
            Rede.Humor h = Rede.Humor.LoadById( Convert.ToInt32(DropDownList1.SelectedValue));
            prof.humor = h;
            prof.Telemovel = Convert.ToInt32(TextTlm.Text);
            Rede.Avatar a = new Rede.Avatar(TextAvatar.Text);
            prof.avatar =a ;
            prof.X = 1;
            prof.Y = 1;
            prof.Save();

        }
    }
}
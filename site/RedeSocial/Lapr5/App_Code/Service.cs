﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections;
using Prolog;
using System.Web.Security;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    public class Service : IService
    {
        public void DoWork()
        {
        }


        public int Add(int x, int y)
        {

            return x + y;
        }

        public IList<NoBD> GetAllXY()
        {
            IList<NoBD> ret = new List<NoBD>();
            //IList idl = new ArrayList();
            //IList xl = new ArrayList();
            //IList yl = new ArrayList();
            IList lista = Rede.Perfil.LoadAll();
            ret.Add(new NoBD(lista.Count, 0, 0, "", "", "", 0));
            for (int i = 0; i < lista.Count; i++)
            {
                int id = ((Rede.Perfil)lista[i]).ID;
                Utilizador nome = GetUtilizadorByID(id);
                string avatar3d = Rede.Perfil.getAvatar3DByID(id);
                int numtags = Rede.Perfil.LoadTagsByUserID(id).Count;
                ret.Add(new NoBD(id, ((Rede.Perfil)lista[i]).X, ((Rede.Perfil)lista[i]).Y, Rede.Perfil.getHumorByPrefilID(id), nome.nome, avatar3d, numtags));
                //idl.Add(((Rede.Perfil)lista[i]).ID);
                //xl.Add(((Rede.Perfil)lista[i]).X);
                //yl.Add(((Rede.Perfil)lista[i]).Y);
            }

            return ret;

        }
        public IList<ArcoBD > GetAllArcoBD()
        {
            IList<ArcoBD> ret = new List<ArcoBD>();
            //IList idl = new ArrayList();
            //IList xl = new ArrayList();
            //IList yl = new ArrayList();

            IList lista = Rede.Relacao.LoadAll();
            ret.Add(new ArcoBD(lista.Count, 0, 0, 0));
            for (int i = 0; i < lista.Count; i++)
            {
                
                ret.Add(new ArcoBD(((Rede.Relacao)lista[i]).ID, ((Rede.Relacao)lista[i]).ProfileIDA, ((Rede.Relacao)lista[i]).ProfileIDB, ((Rede.Relacao)lista[i]).Forca));
                //idl.Add(((Rede.Perfil)lista[i]).ID);
                //xl.Add(((Rede.Perfil)lista[i]).X
                //yl.Add(((Rede.Perfil)lista[i]).Y);
            }

            return ret;

        }

        public Utilizador GetUtilizadorByID(int uid)
        {
            
         

            Rede.Perfil perfil = Rede.Perfil.LoadById(uid);
            Utilizador util = new Utilizador(perfil.Name,perfil.Nick,perfil.Morada,perfil.Telemovel,perfil.DataNascimento.ToString(),perfil.avatar);
            
            

            return util;

        }

        public IList<string> GetTagsByUserID(int uid)
        {
           // IList<Designacao> ret= new List<Designacao>();
            IList<string> tags = Rede.Perfil.LoadTagsByUserID(uid);
            //for (int i = 0; i < tags.Count; i++)
            //{
            //    ret.Add(new Designacao(tags[i]));
            //}
                return tags;

        }
        public string GetHumorByUserID(int uid)
        {

            string humor = Rede.Perfil.getHumorByPrefilID(uid);

            return humor;

        }

        public string getMenorCaminho(int no1,int no2 )
        {
            PrologExec p = new PrologExec(no1+"_"+no2, "menorCaminho");
            string res = p.executaComandoProlog(no1+","+no2+",P");
            return res;
        }

        public string getCaminhoForte(int no1, int no2)
        {
            PrologExec p = new PrologExec(no1+"_"+no2, "caminhoMaisForte");
            string res = p.executaComandoProlog(no1+","+no2+",P");
            return res;
        }

        public int validateLogin(string userName, string password)
        {
            if (Membership.ValidateUser(userName, password))
            {
                var userId = (Guid)(Membership.GetUser(userName,false).ProviderUserKey);
                Rede.Perfil user=Rede.Perfil.LoadByUserId(userId.ToString());
                return user.ID;
            }
            else
            {
                return 0;
            }
        }

        public string xTagsEmComum(int id,int n)
        {
            ///*lista os amigos do User com N tags em comum*/
            PrologExec p = new PrologExec(""+id, "xTagsEmComum");
            string res = p.executaComandoProlog(id+","+n);
            return res;
        }

        public int tamanhoRedeUtilizador(int id)
        {
            PrologExec p = new PrologExec(""+id, "tamanhoRedeUtilizador");
            string res = p.executaComandoProlog(""+id);
            try
            {
                return Convert.ToInt32(res);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            return -1;
        }

        public string sugereAmigos(int id)
        {
            PrologExec p = new PrologExec(id+"", "recomendaAmizade");
            string res = p.executaComandoProlog(id+"");
            return res;
        }
    }

     

   

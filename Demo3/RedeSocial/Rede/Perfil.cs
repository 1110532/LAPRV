﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rede
{
    public class Perfil : ActiveRecord
    {
        private string _userID;
        private string _name;
        private string _nick;
        private DateTime _datanasc;
        private string _morada;
        private int _tlm;
        private string _lk;
        private string _fb;
        private Humor _humor;
        private string _avatar;
        private string _avatar3D;
        private int _x;
        private int _y;
        private bool _premium;
        private IList _tags;

        public Perfil()
        {

        }
        public Perfil(string uid, string nm)
        {

            this._userID = uid;

            this._name = nm;
            this._nick = "";
            string date = "01/08/1900";
            this._datanasc = Convert.ToDateTime(date); 
            this._morada = "";
            this._tlm = 0;
            this._lk = "";
            this._fb = "";
            this._humor = Rede.Humor.LoadById(2);
            this._avatar = "";
            this._avatar3D = "";
            int[] v = new int[2];
            v = atribuirCoord();
            this._x = v[0];
            this._y = v[1];
            this._premium = false;
        }
        public Perfil(int id, string uID, string Name, string Nick, DateTime dataNasc, string morada, int tlm, string lk, string fb, Humor humor, string avatar3D, string avatar, int x, int y, bool prem)
        {
            this.myID = id;
            this._userID = uID;
            this._name = Name;
            this._nick = Nick;
            this._datanasc = dataNasc;
            this._morada = morada;
            this._tlm = tlm;
            this._lk = lk;
            this._fb = fb;
            this._humor = humor;
            this._avatar3D = avatar3D;
            this._avatar = avatar;
            this._x = x;
            this._y = y;
            this._premium = prem;
        }


        public string UsID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public DateTime DataNascimento
        {
            get { return _datanasc; }
            set { _datanasc = value; }
        }

        public string Morada
        {
            get { return _morada; }
            set { _morada = value; }
        }

        public int Telemovel
        {
            get { return _tlm; }
            set { _tlm = value; }
        }

        public string FaceBook
        {
            get { return _fb; }
            set { _fb = value; }
        }
        public string Linkedin
        {
            get { return _lk; }
            set { _lk = value; }
        }
        public Humor humor
        {
            get { return _humor; }
            set { _humor = value; }
        }

        public string avatar3D
        {
            get { return _avatar3D; }
            set { _avatar3D = value; }
        }

        public string avatar
        {
            get { return _avatar; }
            set { _avatar = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public IList Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }

        public bool Premium
        {
            get { return _premium; }
            set { _premium = value; }
        }
        protected Perfil(DataRow row)
        {
            this.myID = (int)row["ProfileID"];
            this._userID = (string)row["UserID"];
            this._name = (string)row["Nome"];
            this._nick = (string)row["Nick"];
            this._morada = (string)row["Morada"];
            this._datanasc = (DateTime)row["DataNascimento"];
            this._tlm = (int)row["Telemovel"];
            this._fb = (string)row["Facebook"];
            this._lk = (string)row["Linkedin"];
            this._avatar3D = (string)row["Avatar3D"];
            this._avatar = (string)row["Avatar"];
            this._humor = Humor.LoadById((int)row["HumorID"]);
            this._x = (int)row["X"];
            this._y = (int)row["Y"];
            this._premium = (bool)row["Premium"];
        }
        public Perfil(int ID, int x, int y, IList tags)
        {
            // TODO: Complete member initialization
            this.myID = ID;
            this._x = x;
            this._y = y;
            this._tags = tags;
        }


        public override string ToString()
        {
            return _name;
        }

        public static Perfil LoadByProfileId(string profileID)
        {
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT * FROM TProfile WHERE ProfileID=" + profileID);
            if (ds.Tables[0].Rows.Count != 1)
                return null;
            else
                return new Perfil(ds.Tables[0].Rows[0]);
        }

        public static String LoadNameByProfileId(int profileID)
        {
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT Nome FROM TProfile WHERE ProfileID=" + profileID);

            return ds.Tables[0].Rows[0]["Nome"].ToString();
        }

        public static String LoadNickByProfileId(int profileID)
        {
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT Nick FROM TProfile WHERE ProfileID=" + profileID);

            return ds.Tables[0].Rows[0]["Nick"].ToString();
        }

        public static int LoadProfileIDByUserId(String userID)
        {
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT ProfileID FROM TProfile WHERE UserID='" + userID + "'");

            return Convert.ToInt32(ds.Tables[0].Rows[0]["ProfileID"].ToString());
        }

        public static Perfil LoadById(int customerID)
        {
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT * FROM TProfile WHERE ProfileID=" + customerID);
            if (ds.Tables[0].Rows.Count != 1)
                return null;
            else
                return new Perfil(ds.Tables[0].Rows[0]);
        }

        public static Perfil LoadByUserId(string customerID)
        {
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT * FROM TProfile WHERE UserID='" + customerID + "'");
            if (ds.Tables[0].Rows.Count != 1)
                return null;
            else
                return new Perfil(ds.Tables[0].Rows[0]);
        }
        public static Perfil LoadByName(string Nam)
        {
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT * FROM TProfile WHERE Nome='" + Nam + "'");
            if (ds.Tables[0].Rows.Count != 1)
                return null;
            else
                return new Perfil(ds.Tables[0].Rows[0]);
        }

        public static IList LoadAll()
        {
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT * FROM TProfile");

                IList ret = new ArrayList();

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Perfil c = new Perfil(r);
                    ret.Add(c);

                    //apagar
                    // save in registry
                    //loaded[p.ID] = p;
                }

                return ret;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }

        public static int get_UsersRegistados()
        {
            int N_users = 0;
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT * FROM TProfile");



                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    N_users++;
                }


            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }

            return N_users;

        }

        public string toFile()
        {   //no(NoID,[listaTags,listaTags],PosX,PosY)
            String txt = "no(";
            txt += ID + ",";
            txt += "[";
            if (Tags.Count == 0)
            {
                txt += "]";
            }
            else
            {
                for (int x = 0; x < Tags.Count; x++)
                {
                    if (x == Tags.Count - 1)
                    {
                        txt += Tags[x] += "]";
                    }
                    else
                    {
                        txt += Tags[x] + ",";
                    }
                }
            }
            txt += ",";
            txt += X + ",";
            txt += Y + ").";
            return txt;
        }



        public override void Save()
        {
            if (this.ID != 0)
            {
                ExecuteNonQuery("UPDATE TProfile SET Nome='" + this._name + "',Nick= '" + this._nick + "',Morada= '" + this._morada + "',DataNascimento='" + this._datanasc.ToString("yyyy-MM-dd") + "',Telemovel=" + this._tlm + ",Linkedin='" + this._lk + "', Facebook='" + this._fb + "',HumorID=" + this._humor.ID + ", Avatar3D='" + this._avatar3D + "', Avatar='" + this._avatar + "',X=" + this._x + ", Y=" + this._y + ",Premium='" + this._premium + "'WHERE ProfileID=" + this.ID);
            }
            else
            {


                this.humor = Humor.LoadById(2);

                this.myID = ExecuteNonQuery("INSERT INTO TProfile(UserID, Nome, Nick, Morada, DataNascimento, Telemovel, Facebook, Linkedin, Avatar3D, Avatar, HumorID, X, Y, Premium)   VALUES('" + this.UsID + "','" + this.Name + "','" + this.Nick + "','" + this.Morada + "','" + this.DataNascimento.ToString("yyyy-MM-dd") + "'," + this.Telemovel + ",'" + this.Linkedin + "','" + this.FaceBook + "','" + this.avatar3D + "','" + this.avatar + "'," + this.humor.ID + "," + this.X + "," + this.Y + ",'" + this.Premium + "')");


            }
        }
        public static IList<string> LoadTagsByUserID(int userID)
        {
            IList<string> ret = new List<string>();
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT TagID FROM TTags where ProfileID=" + userID);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int TagID = (int)row["TagID"];
                    try
                    {
                        DataSet dsTag = ExecuteQuery(GetConnection(false), "SELECT Designacao FROM TTag where TagID=" + TagID);

                        foreach (DataRow r in dsTag.Tables[0].Rows)
                        {
                            string tag = (string)r["Designacao"];
                            ret.Add(tag);
                        }
                    }
                    catch (Exception ex)
                    {
                        //throw new ApplicationException("Erro BD", ex);
                    }
                }

            }
            catch (Exception ex)
            {
                //throw new ApplicationException("Erro BD", ex);
            }

            return ret;
        }
        public static string getHumorByPrefilID(int profileID)
        {
            IList ret = new ArrayList();
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT HumorID FROM TProfile where ProfileID=" + profileID);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int HumorID = (int)row["HumorID"];
                    try
                    {
                        DataSet dsTag = ExecuteQuery(GetConnection(false), "SELECT Designacao FROM THumor where HumorID=" + HumorID);

                        foreach (DataRow r in dsTag.Tables[0].Rows)
                        {
                            string humor = (string)r["Designacao"];
                            return humor;
                        }
                    }
                    catch (Exception ex)
                    {
                        //throw new ApplicationException("Erro BD", ex);
                    }
                }

            }
            catch (Exception ex)
            {
                //throw new ApplicationException("Erro BD", ex);
            }

            return "";
        }
        public static IList LoadInfoForNos()
        {//no(NoID,[listaTags],PosX,PosY)
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT ProfileID,X,Y FROM TProfile");

                IList ret = new ArrayList();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ProfileID"];
                    int x = (int)row["X"];
                    int y = (int)row["Y"];
                    IList tags = TagsByUserID(ID);
                    Perfil c = new Perfil(ID, x, y, tags);
                    ret.Add(c);
                }

                return ret;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }
        }
        public static IList TagsByUserID(int userID)
        {
            IList ret = new ArrayList();
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT TagID FROM TTags where ProfileID=" + userID);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int TagID = (int)row["TagID"];
                    try
                    {
                        DataSet dsTag = ExecuteQuery(GetConnection(false), "SELECT Designacao FROM TTag where TagID=" + TagID);

                        foreach (DataRow r in dsTag.Tables[0].Rows)
                        {
                            string tag = (string)r["Designacao"];
                            ret.Add(tag);
                        }
                    }
                    catch (Exception ex)
                    {
                        //throw new ApplicationException("Erro BD", ex);
                    }
                }

            }
            catch (Exception ex)
            {
                //throw new ApplicationException("Erro BD", ex);
            }

            return ret;
        }
        public static string getAvatar3DByID(int profid)
        {
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT Avatar3D FROM TProfile WHERE ProfileID=" + profid);
            if (ds.Tables[0].Rows.Count != 1)
                return "Não tem";
            else
                return (string)ds.Tables[0].Rows[0]["Avatar3D"];

        }




        public static int getMaxX()
        {
            int user_X;
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT MAX(X) FROM TProfile");
                user_X = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }

            return user_X;
        }
        public static int getMaxY()
        {
            int user_Y;
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT MAX(Y) FROM TProfile");
                user_Y = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }

            return user_Y;
        }
        public static int getMinX()
        {
            int user_X;
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT Min(X) FROM TProfile");
                user_X = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }

            return user_X;
        }

        public static int getMinY()
        {
            int user_Y;
            try
            {
                DataSet ds = ExecuteQuery(GetConnection(false), "SELECT Min(Y) FROM TProfile");
                user_Y = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro BD", ex);
            }

            return user_Y;
        }

        public static Boolean valiadateCoord(int x, int y)
        {
            int xinf = x - 5;
            int xsup = x + 5;
            int yinf = y - 5;
            int ysup = y + 5;
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT * FROM TProfile where (X between " + xinf + " and " + xsup + ") and (Y between " + yinf + " and " + ysup + ")");
            if (ds.Tables[0].Rows.Count == 0)
                return true;
            else
                return false;
        }

        public static int[] atribuirCoord()
        {
            Random rnd = new Random();
            int x = 0, newCoordX = 0;
            int y = 0, newCoordY = 0;
            do
            {
                int rndNumber = rnd.Next(0, 3);
                switch (rndNumber)
                {
                    case 0:
                        x = Rede.Perfil.getMinX()-5;
                        y = Rede.Perfil.getMaxY()+5;
                        break;
                    case 1:
                        x = Rede.Perfil.getMaxX()+5;
                        y = Rede.Perfil.getMinY()-5;
                        break;
                    case 2:
                        x = Rede.Perfil.getMinX()-5;
                        y = Rede.Perfil.getMinY()-5;
                        break;
                    case 3:
                        x = Rede.Perfil.getMaxX()+5;
                        y = Rede.Perfil.getMaxX()+5;
                        break;
                    default:
                        x = 10;
                        y = 10;
                        break;
                }
                //int rndOp = rnd.Next(0, 1);
                //if (rndOp == 0)
                //{
                //    newCoordX = x + 5;
                //    newCoordY = y + 5;
                //}
                //if (rndOp == 1)
                //{
                //    newCoordX = x - 5;
                //    newCoordY = y - 5;
                //}
            } while (Rede.Perfil.valiadateCoord(x, y));
            //Console.WriteLine(newCoordX+" "+newCoordY);

            int[] vec = new int[2];
            vec[0] = x;
            vec[1] = y;
            return vec;
        }

        public static Boolean verificaPremium(int profid)
        {
            DataSet ds = ExecuteQuery(GetConnection(false), "SELECT Premium FROM TProfile WHERE ProfileID=" + profid);
            if (ds.Tables[0].Rows.Count != 1)
                return false;
            else
                return (Boolean)ds.Tables[0].Rows[0]["Premium"];

        }

    }

}
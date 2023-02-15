using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using OOP_Final_Project.FormsAll;

namespace OOP_Final_Project
{

    public abstract class Con_Que
    {
        private protected string Query;
        private protected Database  _db = new Database();
        private protected int id = User.Passid();
    }

    interface IShow
    {
        DataTable Display();
    }

    //=============================================Database class====================================================


    public class Database
    {
        private static Bitmap imageByte;
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-4C3JK8Q;Initial Catalog=OMS;Integrated Security=True");
        readonly DataTable dt = new DataTable();

        #region DAO-Employee


        //==-------------------Add emp----------------------------

        public void GetsignDataDAO(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                //cmd.Parameters.AddWithValue("@image", this.InsertPhoto());
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Registered Successfully", "REGISTERED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public byte[] InsertPhoto(/*get file from datagrid*/)
        {
            MemoryStream ms = new MemoryStream();
            //picturebox1.Image.Save(ms, picturebox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        public Bitmap DialogBox()
        {
            OpenFileDialog Ofd = new OpenFileDialog();
            Ofd.Title = "Select Image";
            Ofd.Filter = "Image Files(*.PNG; *.BMP; *.JPG; *.GIF)|*.PNG; *.BMP; *.JPG;*.GIF";
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                imageByte = new Bitmap(Ofd.FileName);
            }
            return imageByte;
        }

        //==-------------------Select emp----------------------------

        public DataTable Dis_Emp(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            connect.Open();
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }


        //==-------------------Delte emp----------------------------

        public void Del_Emp(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Deleted successfully", "REMOVE EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                }
                connect.Close();
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DAO-Admin

        //==-------------------Add Admin----------------------------

        public int Log_Admin(string query)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                connect.Open();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connect.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 1;
                }
                else
                {
                    MessageBox.Show("Wrong email or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Admin Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
                return 0;
            }
        }

        #endregion

        #region DAO-Attendence

        //------------------------- ADD Attendence --------------------

        public void Add_Attend(string date, string query, string name, int id)
        {
            try
            {
                SqlDataAdapter dapte = new SqlDataAdapter(query,connect);
                connect.Open();
                dapte.Fill(dt);
                connect.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Attendence already marked", "Attendence", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(@"insert into Attend_data (id, Name, date,Present) 
                    values ('" + id + "','" + name + "','" + date + "','Present')", connect);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Marked present", "Attendence", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connect.Close();
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------- Display Attendence --------------------

        public DataTable Display_att(string query)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                connect.Open();
                adapter.Fill(dt);
                connect.Close();
                return dt;
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

        #region DAO-Events

        //==============Add Events=============

        public void Insert_Events(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Added", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Fill al fields", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                }
                connect.Close();
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //==============Display Events=============

        public DataTable Dis_Events(string query)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                connect.Open();
                adapter.Fill(dt);
                connect.Close();
                return dt;
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //==-------------------Delte emp----------------------------

        public void Del_Event(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Deleted successfully", "REMOVE EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                }
                connect.Close();
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DAO-User
        public int Emp_Login(string query, string Email, string Pass)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 1;
                }
                else
                {
                    MessageBox.Show("Wrong email or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
                return 0;
            }
        }

        private int a = 999999999;
        public int Get_id(string Email,string Pass)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"select id from Emp_data
                 where Email ='" + Email + "'", connect);
                connect.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                a = rd.GetInt32(0);
                connect.Close();
                return a;
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
                return 999999999;
            }
        }

        //------------------------------Display User-----------------------------

        private string T = "";

        public string Get(string txt, string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                T = rd[txt].ToString();
                connect.Close();
                return T;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "GetTEXT", MessageBoxButtons.OK);
                connect.Close();
                return "";
            }
        }
        public Image Get_image(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                byte[] byte_image = (byte[])rd["Photo"];
                MemoryStream MS = new MemoryStream(byte_image);
                connect.Close();
                return Image.FromStream(MS);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "GetIMAGE", MessageBoxButtons.OK);
                return null;
            }
        }

        #endregion

        #region DAO-Department
        public string Dis_Depart(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                string a = rd["city"].ToString();
                connect.Close();
                return a;
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
                return null;
            }
        }

        public string Get_dep_data(string query, string Col_nme)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                SqlDataReader rder = cmd.ExecuteReader();
                rder.Read();
                string data = rder[Col_nme].ToString();
                connect.Close();
                return data;
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
                return "";
            }
        }
        #endregion

        #region DAO-LeaveApply

        public bool Add_Leave(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successful", "Leave Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                    return true;
                }
                else
                {
                    Exception excep = new Exception();
                    MessageBox.Show(excep.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connect.Close();
                    return false;
                }
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        } 


        public bool Del_Leave(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Deleted", "Leave Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                    return false;
                }
                else
                {
                    MessageBox.Show("There were no leave applications found", "Leave Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.Close();
                    return true;
                }
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        #endregion

        #region DAO-Payroll

        public void Insert_Pay(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            if (adapter.Fill(dt) > 0)
            {
                MessageBox.Show("Payroll added", "Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Task Failed", "Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable Update_Pay(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            connect.Open();
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }

        public DataTable Dis_pay(string query)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                connect.Open();
                adapter.Fill(dt);
                connect.Close();
                return dt;
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

        #region DAO-Work

        public void Insert_Work(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connect);
            connect.Open();
            int a = cmd.ExecuteNonQuery();
            connect.Close();
            if (a > 0)
            {
                MessageBox.Show("Work added", "Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Task Failed", "Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //--------------------------Display code-----------

        public DataTable Dis_work(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            connect.Open();
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }

        //--------------------------Delete code-----------

        public void Del_work(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connect);
            connect.Open();
            int a = cmd.ExecuteNonQuery();
            connect.Close();
            if(a > 0)
            {
                MessageBox.Show("Successfully deleted", "Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region DAO-Contacts
        public void Insert_contacts(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            if (adapter.Fill(dt) > 0)
            {
                MessageBox.Show("Contacts added", "contacts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Task Failed", "contacts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Del_contacts(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connect);
            connect.Open();
            int a = cmd.ExecuteNonQuery();
            connect.Close();
            if (a > 0)
            {
                MessageBox.Show("Successfully deleted", "contacts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public DataTable Dis_contacts(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            connect.Open();
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }

        #endregion
    }



    //=============================================Employee class====================================================


    public class Employee : User,  IShow
    {
        #region Insertdata

        public void Insert(string aName, string aPass, string aEmail, string aAddress, string aDepart)
        {

            Query = "insert into Emp_data (Name, Email, Pass, Address, city) values ('" + aName + "','" + aEmail + "','" + aPass + "','" + aAddress + "','" + aDepart + "' )";/*, @image*/
            _db.GetsignDataDAO(Query);
        }

        #endregion

        #region DeleteEmployee

        public void Delete(int sno)
        {
            Query = "delete from Emp_data where id = '" + sno + "'";
            _db.Del_Emp(Query);
        }

        #endregion

        #region ListEmployees

        public new DataTable Display()
        {
            Query = "Select * from Emp_data";
            return _db.Dis_Emp(Query);
        }

        #endregion
    }



    //=============================================Upcoming events CLASS====================================================

    public class Admin : User
    {
        #region Login-Admin

        public int Display(string aPass, string aEmail)
        {
            Query = "select Email, Pass from Admin_data where Email = '" + aEmail + "' and Pass = '" + aPass + "'";
            return _db.Log_Admin(Query);
        }

        #endregion
    }

    //=============================================Attendence CLASS====================================================


    public class Attendence : Con_Que, IShow
    {

        #region PresentEmployees

        public DataTable Pr_data()
        {
            Query = "Select * from Attend_data where id = '" + id + "'";
            return _db.Display_att(Query);
        }
        #endregion

        #region AbsentEmployees

        public DataTable Ab_data()
        {
            Query = "Select Absent from Attend_data where id = '" + id + "'";
            return _db.Display_att(Query);
        }
        #endregion

        #region AddAttendence
        public void Insert()
        {
            User Usr = new User();
            string name = Usr.nm();
            DateTime date = DateTime.Now.Date;
            Query = "select date from Attend_data where date = '" + date + "' and id = '" + id + "'";
            string d = Convert.ToString(date);
            _db.Add_Attend(d, Query, name, id);
        }
        #endregion

        #region CheckAttendence
        public DataTable Display()
        {
            Query  = @"select * from Attend_data ";
            return _db.Display_att(Query);
        }
        #endregion
    }


    //=============================================Upcoming events CLASS====================================================


    public class UpEvents : Con_Que, IShow
    {

        #region AddEvent
        public void Insert(string data, string Eventdate)
        {
            Query = "insert into Event_data (Event, date) values ('" + data + "','" + Eventdate + "')";
            _db.Insert_Events(Query);
        }
        #endregion

        #region RemoveEvent
        public void Delete(int sno)
        {
            Query = @"delete from Event_data where id = '" + sno + "'";
            _db.Del_Event(Query);
        }
        #endregion

        #region CheckEvent
        public DataTable Display()
        {
            Query = "select * from Event_data";
            return _db.Dis_Events(Query);
        }
        #endregion
    }


    //=============================================Payload CLASS====================================================


    public class Payroll : Con_Que, IShow
    {
        #region AddPay
        public void add(string pay, string aID)
        {
            Query = "Insert into Emp_data payroll = '" + pay + "' where id = '" + aID + "'";
            _db.Insert_Pay(Query);
        }

        #endregion

        #region UpdatePay

        public DataTable Update(string pay , int aID)
        {
            Query = "Update Emp_data set payroll = '" + pay + "' where id = '" + aID + "'";
            return _db.Update_Pay(Query);
        }

        #endregion

        #region CheckPay
        public DataTable Display()
        {
            Query = "select id, Name, payroll from Emp_data where id = '" + id + "'";
            return _db.Dis_pay(Query);
        }
        #endregion

        #region DisplayAll
        public DataTable Dis_all()
        {
            Query = "select id, Name, payroll  from Emp_data";
            return _db.Dis_pay(Query);
        }
        #endregion
    }


    //=============================================Department CLASS====================================================


    public class Department : Con_Que
    {
        private static string city;
        private static string Location, Timing, Head, Phone;

        #region CheckDepart
        public void Display()
        {
            Query = "select city from Emp_data where id = '" + id + "'";
            city = _db.Dis_Depart(Query);
        }

        public string Loc()
        {
            Query = @"select Location from Loc_data where Location = '" + city + "'";
            Location = _db.Get_dep_data(Query, "Location");
            return Location;
        }

        public string Tim()
        {
            Query = @"select Timing from Loc_data where Location = '" + city + "'";
            Timing = _db.Get_dep_data(Query, "Timing");
            return Timing;
        }
        public string Hd()
        {
            Query = @"select Head from Loc_data where Location = '" + city + "'";
            Head = _db.Get_dep_data(Query, "Head");
            return Head;
        }
        public string Ph()
        {
            Query = @"select Phone from Loc_data where Location = '" + city + "'";
            Phone = _db.Get_dep_data(Query, "Phone");
            return Phone;
        }
        #endregion
    }


    //=============================================Leave CLASS====================================================


    public class Leave_Application : Con_Que
    {
        private static string LevReas;

        #region LeaveAdd
        public void LeaveAsk(string a)
        {
            LevReas = a;
            Query = "insert into Leave_data values('" + id + "', '" + LevReas + "')";
            _db.Add_Leave(Query);
        }
        #endregion

        #region LeaveRemove
        public void LeaveAsk_cancel()
        {
            Query = "delete from Leave_data where id = '" + id + "'";
            _db.Del_Leave(Query);
        }

        public void Leave_Delete(int sno)
        {
            Query = "delete from Leave_data where id = '" + sno + "'";
            _db.Del_Leave(Query);
        }
        #endregion

        #region LeaveDisplay

        public DataTable Display()
        {
            Query = "select * from Leave_data where id = '" + id + "'";
            return _db.Dis_work(Query);
        }

        #endregion

        #region Leaveall

        public DataTable Dis_all()
        {
            Query = "select * from Leave_data";
            return _db.Dis_work(Query);
        }

        #endregion
    }


    //=============================================Upcoming events CLASS====================================================


    public class User : Con_Que
    {
        private static int userid;
        private static string Email, Pass;
        private static string Name, Address;
        private static Image pic;

        public static int Passid()
        {
            return userid;
        }

        #region user_log

        public int Login(string aEmail, string aPass)
        {
            Email = aEmail;
            Pass = aPass;
            Query = "select Email, Pass from Emp_data where Email = '" + Email + "' and Pass = '" + Pass + "'";
            int a = _db.Emp_Login(Query,Email,Pass);
            if (a > 0)
            {
                userid = _db.Get_id(aEmail, aPass);
            }
            return a;
        }

        #endregion

        #region UserDisplay 

        public string nm()
        {
            if(userid != 999999999)
                Name = _db.Get("Name", "Select Name From Emp_data where id = '" + userid + "'");
                return Name;
        }
        public string Eml()
        {
            if (userid != 999999999)
                Email = _db.Get("Email", "Select Email From Emp_data where id = '" + userid + "'");
                return Email; 
        }
        public string Add() 
        {
            if (userid != 999999999)
                Address = _db.Get("Address", "Select Address From Emp_data where id = '" + userid + "'");
                return Address;
        }
        public Image picture() 
        {
            if (userid != 999999999)
                pic = _db.Get_image("Select photo From Emp_data where id = '" + userid + "'");
                return pic; 
        }

        #endregion
    }



    //=============================================Workstats CLASS====================================================



    public class WorkStats : Con_Que,IShow
    {
        private string Name;

        #region WorkInsert

        public void Insert(string work, string About)
        {
            User uS = new User();
            Name = uS.nm();
            Query = "insert into work_data (id, Name, FileLink, FileAbout) values ('" + id + "', '" + Name + "', '" + work + "', '" + About + "')";
            _db.Insert_Work(Query);
        }

        #endregion

        #region WorkRemove

        public void Delete(int sno)
        {
            Query = "delete from work_data where id = '" + sno + "'";
            _db.Del_work(Query);
        }

        #endregion

        #region WorkDisplay

        public DataTable Display()
        {
            Query = "select * from Work_data where id = '" + id + "'";
            return _db.Dis_work(Query);
        }

        #endregion

        #region Display All

        public DataTable Dis_all()
        {
            Query = "select * from Work_data";
            return _db.Dis_work(Query);
        }

        #endregion
    }



    //=============================================Contacts CLASS====================================================


    public class Contacts : Con_Que, IShow
    {
        #region ContactsInsert

        public void Insert(string data, string ph)
        {
            Query = "insert into contacts_data (contact, Phone) values ('" + data + "','" + ph + "')";
            _db.Insert_contacts(Query);
        }

        #endregion

        #region ContactsRemove

        public void Delete(int Sno)
        {
            Query = "delete from contacts_data where id = '" + Sno + "'";
            _db.Del_contacts(Query);
        }

        #endregion

        #region ContactsDisplay

        public DataTable Display()
        {
            Query = "select * from contacts_data";
            return _db.Dis_contacts(Query);
        }

        #endregion
    }
}

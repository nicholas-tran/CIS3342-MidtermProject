using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MidTermExam
{
    public partial class Default : System.Web.UI.Page
    {
        List<string> mealPlan = new List<string>();
        string person;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mealPlan = (List<string>)Session["MealPlan"];
                DBConnect objDB = new DBConnect();
                DataSet ds = new DataSet();
                string sqlString = "Select * FROM dbo.Person";
                ds = objDB.GetDataSet(sqlString);
                ddlFindPerson.DataSource = ds.Tables[0];
                ddlFindPerson.DataValueField = "PersonID";
                ddlFindPerson.DataTextField = "Name";
                ddlFindPerson.DataBind();
                ddlFindPerson2.DataSource = ds.Tables[0];
                ddlFindPerson2.DataValueField = "PersonID";
                ddlFindPerson2.DataTextField = "Name";
                ddlFindPerson2.DataBind();
            }
        }

        protected void ddlFindPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            person = ddlFindPerson.SelectedValue;
            Session["PersonID"] = person;
        }

        protected void ddlFindPerson2_SelectedIndexChanged(object sender, EventArgs e)
        {
            person = ddlFindPerson.SelectedValue;
            Session["PersonID"] = person;
            gvShowMeal.Visible = false;
        }

        protected void btnSaveMeal_Click(object sender, EventArgs e)
        {
            int person = Convert.ToInt32(ddlFindPerson.SelectedValue);
            string day = txtDay.Text;
            string meal = txtMealDay.Text;
            string description = txtMealDescription.Text;
            string calories = txtCalories.Text;
            string fat = txtFat.Text;
            string carbs = txtCarbs.Text;
            string newMeal = person + "," + day + "," + meal + "," + description + "," + calories + "," + fat + "," + carbs;
            mealPlan.Add(newMeal);
            Session["MealPlan"] = mealPlan;
            txtCalories.Text = "";
            txtCarbs.Text = "";
            txtDay.Text = "";
            txtFat.Text = "";
            txtMealDay.Text = "";
            txtMealDescription.Text = "";
        }

        protected void btnRecordMeals_Click(object sender, EventArgs e)
        {
            mealPlan = (List<string>)Session["MealPlan"];
            for (int i =0; i< mealPlan.Count; i++)
            {
                DBConnect objDB = new DBConnect();
                string newMeal = mealPlan[i].ToString();
                string[] mealArray = newMeal.Split(',');
                string sqlString = "INSERT INTO MealPlan (PersonID, Day, MealOfDay, MealDescription, Calories, Fat, Carbs) " +
                    "VALUES ('" + mealArray[0] + "','" + mealArray[1] + "','" + mealArray[2] + "','" + mealArray[3] + "','" + mealArray[4] + "','" + mealArray[5] + "','" + mealArray[6] + "')";
                objDB.DoUpdate(sqlString);
            }
        }

        protected void btnFindPerson_Click(object sender, EventArgs e)
        {
            string personID = ddlFindPerson2.SelectedValue;
            DBConnect objDB = new DBConnect();
            string sqlString = "SELECT * FROM MealPlan WHERE PersonID = '" + personID + "'";
            DataSet ds = new DataSet();
            ds = objDB.GetDataSet(sqlString);
            gvShowMeal.DataSource = ds;
            gvShowMeal.DataBind();
            gvShowMeal.Visible = true;
        }
    }
}
namespace Full_GRASP_And_SOLID
{
    // Agregado por ISP.
    public class Time : TimerClient
    {
        public Recipe Recipe;

        public Time(Recipe recipe)
        {
            this.Recipe = recipe;
        }


        //Ley de Demeter.
        public void TimeOut()
        {
            Recipe.ChangeCookedStatus();
        }
    }
}
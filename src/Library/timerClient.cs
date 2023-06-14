namespace Full_GRASP_And_SOLID
{
    public class timerClient : TimerClient
    {
        public timerClient(Recipe recipe){
            this.recipe = recipe;
        }
        Recipe recipe;
        public void TimeOut()
        
        {
            recipe.SetCooked();
        }

    }
}
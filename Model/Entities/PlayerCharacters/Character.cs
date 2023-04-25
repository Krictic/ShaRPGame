namespace ShaRPGame.Model.Entities.PlayerCharacters
{
    internal class Character : IEntity
    {

        private string Name { set; get; } = "Character";
        private string Biography { set; get; } = "that I am but a modest Placeholder";
        private string JobClass { set; get; } = "Placeholder";
        private int Age { set; get; } = 20;
        private int Level { set; get; } = 1;

        public string attack()
        {
            return $"{this.Name} dttacks!";
        }

        public string defend()
        {
            return $"{this.Name} defends!";
        }

        public string speak()
        {
            string name = this.Name;
            string biography = this.Biography;
            string jobClass = this.JobClass;
            int age = this.Age;
            int level = this.Level;

            return $"My name is {name} and I am {age}, my bio is {biography} and im currently a level {level} {jobClass}.";
        }
    }
}

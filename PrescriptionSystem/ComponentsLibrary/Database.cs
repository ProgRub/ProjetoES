namespace ComponentsLibrary
{
    public static class Database
    {
        public static PrescriptionSystemDbContext GetContext()
        {
            return new PrescriptionSystemDbContext();
        }

    }
}
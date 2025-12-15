namespace TrelloRepo
{
    public static class RepoFactory
    {
        public static IRepo GetRepo() => new MemoryRepo();
    }
}

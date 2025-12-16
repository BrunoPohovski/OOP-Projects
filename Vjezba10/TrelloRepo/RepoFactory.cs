namespace TrelloRepo
{
    // Simple factory to centralize repository creation; public so callers in other
    // assemblies can obtain an implementation without knowing its concrete type.
    public static class RepoFactory
    {
        // Static method keeps factory stateless and easy to call; currently returns
        // the in-memory implementation but can later swap to another IRepo.
        //public static IRepo GetRepo() => new MemoryRepo();

        public static IRepo GetRepo() => new FileRepo();
    }
}

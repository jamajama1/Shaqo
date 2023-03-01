namespace Shaqo.Permissions;

public static class ShaqoPermissions
{
    public const string GroupName = "Shaqo";

    //Add your own permission names. Example:
    public static class Jobs
    {
        public const string Default = GroupName + ".Jobs";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}

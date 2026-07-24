namespace SchoolManagementSystem.Models
{
    // From the workshop, Module 8 ("Users, Roles & Permissions") and Module 13
    // (the "Design the Access" activity): this school system has exactly four
    // roles. Keeping them as constants -- instead of typing "Teacher" as a
    // plain string everywhere -- means a typo like "Teachar" is caught by the
    // compiler instead of silently creating a brand-new, useless role.
    //
    // ===== WHY "static class"? =====
    // A normal class is a blueprint you make OBJECTS from, e.g. `new User()`.
    // Every object gets its own copy of the fields, and you need an instance
    // before you can use anything on it.
    //
    // RoleNames isn't a "thing" you create many of -- there's only ever ONE
    // fixed list of roles for the whole app. It doesn't need instance state
    // (no per-object Name/Email like User has) and nothing about it changes
    // at runtime. `static` says exactly that:
    //   - You can NEVER write `new RoleNames()` -- the compiler forbids it,
    //     because there's nothing to construct.
    //   - Everything inside must also be `static` (or `const`, which is
    //     implicitly static) -- there's no instance to attach non-static
    //     members to.
    //   - You call its members directly on the class name, from anywhere,
    //     with no object in between: `RoleNames.Teacher`, `RoleNames.All`.
    //
    // This is the same reason `Math` (as in `Math.Max(1, 2)`) is a static
    // class in .NET -- it's just a bag of related constants/helpers, not a
    // thing you instantiate. Use `static class` whenever you want a small,
    // shared "toolbox" or "constants list" rather than a blueprint for
    // making individual objects.
    public static class RoleNames
    {
        public const string Student = "Student";
        public const string Teacher = "Teacher";
        public const string Principal = "Principal";
        public const string Accountant = "Accountant";

        // Handy combos for [Authorize(Roles = "...")] attributes, which need a
        // single comma-separated string. Const string concatenation is
        // evaluated at compile time, so this is still a valid attribute argument.
        public const string TeacherOrPrincipal = Teacher + "," + Principal;

        // Used by Signup to reject any role that isn't one of the four above.
        public static readonly string[] All = { Student, Teacher, Principal, Accountant };
    }
}

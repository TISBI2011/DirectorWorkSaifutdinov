//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DirectorWorkSaifutdinov.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Patronymic { get; set; }
        public byte[] Avatar { get; set; }
    }
}

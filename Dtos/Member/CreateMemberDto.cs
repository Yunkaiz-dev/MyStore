﻿namespace MyStore.Dtos.Member
{
    public class CreateMemberDto
    {
        public int UserId { get; set; }

        public string MemberPassword { get; set; } = null!;

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }
    }
}
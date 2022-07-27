﻿using System.Collections.Generic;
using MB.Application.Contracts.Comment;

namespace MB.Domain.CommentAgg
{
    public interface ICommentRepository 
    {
        List<CommentViewModel> GetList();
        void CreateAndSave(Comment entity);

        Comment Get(long id);
        void Save();
    }
}
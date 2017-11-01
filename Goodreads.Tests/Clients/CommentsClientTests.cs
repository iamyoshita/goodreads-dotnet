﻿using System.Threading.Tasks;
using Goodreads.Clients;
using Goodreads.Models.Request;
using Xunit;

namespace Goodreads.Tests
{
    public class CommentsClientTests
    {
        private readonly ICommentsEndpoint CommentClient;

        public CommentsClientTests()
        {
            CommentClient = Helper.GetAuthClient().Comments;
        }

        public class TheGetAllCommentsMethod : CommentsClientTests
        {
            [Fact]
            public async Task GetAll()
            {
                const int resourceId = 48510472;
                var type = ResourceType.OwnedBook;

                var comments = await CommentClient.GetAll(resourceId, type);

                Assert.NotNull(comments);
                Assert.NotEmpty(comments.List);
            }
        }
    }
}
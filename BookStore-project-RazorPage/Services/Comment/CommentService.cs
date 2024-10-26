namespace BookStore_project_RazorPage.Services.Comment;

public class CommentService: ICommentService
{
    private HttpClient _httpClient;

    public CommentService(HttpClient httpClient) => _httpClient = httpClient;
}

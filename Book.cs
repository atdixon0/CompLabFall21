namespace CompLabFall21
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author Author; 
        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            tempIsbn = isbn;
            tempTitle = title;
            tempAuthor = Author;
        }
        public string GetIsbn()
        {
            return isbn;
        }
        public void SetIsbn(string tempIsbn)
        {
            this.isbn = tempIsbn;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string tempTitle)
        {
            this.title = tempTitle;
        }
        public Author GetAuthor()
        {
            return Author;
        }
        public void SetAuthor(Author tempAuthor)
        {
            this.Author = tempAuthor;
        }
        public override string ToString()
        {

            return $"isbn = {isbn}, title = {title}, {Author.ToString()}";
        }
    }
}
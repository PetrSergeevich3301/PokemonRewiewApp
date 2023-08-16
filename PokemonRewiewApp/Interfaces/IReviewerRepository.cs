using Microsoft.Identity.Client.Kerberos;
using PokemonRewiewApp.Models;

namespace PokemonRewiewApp.Interfaces
{
    public interface IReviewerRepository
    {
        public ICollection<Reviewer> GetReviewers();
        public Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExist(int reviewerId);
        bool CreateReviewer(Reviewer reviewer);
        bool UpdateReviewer(Reviewer reviewer);
        bool DeleteReviewer(Reviewer reviewer);
        bool Save();
    }
}

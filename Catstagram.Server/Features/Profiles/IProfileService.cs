namespace Catstagram.Server.Features.Profiles
{
    using System.Threading.Tasks;
    using Data.Models;
    using Infrastructure.Services;
    using Models;

    public interface IProfileService
    {
        Task<ProfileServiceModel> ByUser(string userId, bool allInformation = false);

        Task<Result> Update(
            string userId, 
            string email, 
            string userName, 
            string name, 
            string mainPhotoUrl, 
            string webSite, 
            string biography, 
            Gender gender, 
            bool isPrivate);

        Task<bool> IsPublic(string userId);
    }
}

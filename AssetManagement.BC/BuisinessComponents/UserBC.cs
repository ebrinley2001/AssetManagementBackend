using AssetManagement.BC.Helpers;
using AssetManagement.Data;
using AssetManagement.Models;
using AssetManagement.Models.HelperModels;
using EthanFramework.BC.BuisinessComponents;
using System;
using System.Threading.Tasks;

namespace AssetManagement.BC.BuisinessComponents
{
    public class UserBC : BaseEfBc<User, IUserRepository>, IUserBC
    {
        private readonly IUserRepository _userRepository;
        private readonly IStringHelpers _stringHelpers;
        public UserBC(IUserRepository repo, IStringHelpers stringHelpers) : base(repo)
        {
            _userRepository = repo;
            _stringHelpers = stringHelpers;
        }

        public override Task<int> CreateAsync(User entity)
        {
            string plaintext = _stringHelpers.decryptDES(entity.password);
            entity.dateCreated = DateTime.UtcNow;
            entity.password = _stringHelpers.HashString(plaintext, entity.dateCreated.ToString());

            return _userRepository.CreateAsync(entity);
        }

        public async Task<User?> Login(Login loginDetails)
        {
            var user = await _userRepository.getUserByUsernameAsync(loginDetails.username);
            if (user != null)
            {
                var hashedPw = _stringHelpers.HashString(_stringHelpers.decryptDES(loginDetails.password), user.dateCreated.ToString());

                if (user.password == hashedPw)
                {
                    return user;
                }
            }
            return null;
        }
    }
}

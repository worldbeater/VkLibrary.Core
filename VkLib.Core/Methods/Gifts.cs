using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Gifts API section.
    /// </summary>
    public class Gifts
    {
        private Vkontakte _vkontakte;

        internal Gifts(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of user gifts.
        /// Docs: <see href="https://vk.com/dev/gifts.get">gifts.get</see>
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="count">Number of gifts to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        public async Task<ApiItemsResponse<VkLib.Types.Gifts.Gift>> Get(int? user_id = null, int? count = null, int? offset = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());

            return await _vkontakte.GetAsync<ApiItemsResponse<VkLib.Types.Gifts.Gift>>("gifts.get", parameters);
        }

    }
}

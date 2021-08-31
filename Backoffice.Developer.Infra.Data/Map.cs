using MongoDB.Bson.Serialization;
using Backoffice.Developer.Domain.Interface;
using Backoffice.Developer.Infra.Data.Interface;

namespace Backoffice.Developer.Infra.Data
{
    public abstract class Map<T> : IMap where T : IEntity
    {
        public virtual void Configure()
        {
            BsonClassMap.RegisterClassMap<T>(map =>
            {
                map.AutoMap();
                map.MapMember(x => x.Id).SetElementName("_id");
                map.SetIgnoreExtraElements(true);
            });

        }
    }
}

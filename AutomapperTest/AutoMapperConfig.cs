using AutoMapper;

namespace AutomapperTest
{
    internal class AutoMapperConfig
    {
        public static void Config()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile<EntityAToViewModelProfile>();
                cfg.AddProfile<EntityBToViewModelProfile>();
            });
        }
    }

    internal class EntityAToViewModelProfile : Profile
    {
        public EntityAToViewModelProfile()
        {
            CreateMap<EntityA, BaseViewModel>()
                .ForMember(d => d.CreateTimeFromB, x => x.Ignore());

            CreateMap<EntityA, ViewModelA>()
                .IncludeBase<EntityA,BaseViewModel>()
                .ForMember(d => d.PropertyA, x => x.MapFrom(s => s.PropertyA));

            CreateMap<EntityA, ViewModelB>()
                  .IncludeBase<EntityA, BaseViewModel>()
                .ForMember(d => d.PropertyB, x => x.MapFrom(s => s.PropertyB));
        }
    }

    internal class EntityBToViewModelProfile : Profile
    {
        public EntityBToViewModelProfile()
        {
            CreateMap<EntityB, BaseViewModel>()
                .ForMember(d => d.CreateTimeFromB, x => x.MapFrom(s=>s.CreateTime))
                .ForMember(d=>d.CreateTime,x=>x.MapFrom(s=>s.CreateTime));

            //CreateMap<EntityB, ViewModelA>()
            //      .IncludeBase<EntityB, BaseViewModel>()
            //    .ForMember(d => d.PropertyAA, x => x.MapFrom(s => s.PropertyAA));

            //CreateMap<EntityB, ViewModelB>()
            //      .IncludeBase<EntityB, BaseViewModel>()
            //    .ForMember(d => d.PropertyBB, x => x.MapFrom(s => s.PropertyBB));
        }
    }
}
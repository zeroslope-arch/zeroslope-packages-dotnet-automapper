using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSlope.Packages.DotNet.AutoMapper.Installers
{
    public class AutoMapperInstaller
    {
		private readonly MapperConfigurationExpression _expression;

		public AutoMapperInstaller(MapperConfigurationExpression cfg)
        {
			_expression = cfg;
		}

		public void Install(IServiceCollection serviceCollection)
		{
			var configuration = new MapperConfiguration(_expression);
			var mapper = new Mapper(configuration);
			serviceCollection.AddSingleton<IMapper>(mapper);
		}
	}
}

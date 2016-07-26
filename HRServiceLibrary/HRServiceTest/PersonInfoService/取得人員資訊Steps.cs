using System;
using TechTalk.SpecFlow;
using ExpectedObjects;
using HRServiceLibrary.Repository;
using HRServiceLibrary.Service;
using NSubstitute;
using TechTalk.SpecFlow.Assist;
using HRServiceLibrary.Repository.Model;
using System.Collections.Generic;
using HRServiceLibrary.Service.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;


namespace HRServiceTest.PersonInfoService
{
    [Binding]
    public class 取得人員資訊Steps
    {
        private static IPersonInfoService target { get; set; }
        private static IPresonRepository _PresonRepository { get; set; }
        private static IDepartMentRepository _DepartMentRepository { get; set; }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            _PresonRepository = Substitute.For<IPresonRepository>();
            _DepartMentRepository = Substitute.For<IDepartMentRepository>();
            target = new HRServiceLibrary.Service.PersonInfoService
                (
                _PresonRepository,
                _DepartMentRepository
                );
        }

        [Given(@"人員為""(.*)""的資料")]
        public void Given人員為的資料(string p0, Table table)
        {
            var PersonModel = table.CreateSet<PersonModel>();
            ScenarioContext.Current.Set(PersonModel, "PersonModel");
        }
        
        [Given(@"部門為""(.*)""的資料")]
        public void Given部門為的資料(string p0, Table table)
        {
            var DepartMentModel = table.CreateSet<DepartMentModel>();
            ScenarioContext.Current.Set(DepartMentModel, "DepartMentModel");
        }
        
        [When(@"取得人員資訊")]
        public void When取得人員資訊()
        {
            var PersonModel = ScenarioContext.Current.Get<IEnumerable<PersonModel>>("PersonModel");
            var DepartMentModel = ScenarioContext.Current.Get<IEnumerable<DepartMentModel>>("DepartMentModel");
            _PresonRepository.Get().ReturnsForAnyArgs(PersonModel);
            _DepartMentRepository.Get().ReturnsForAnyArgs(DepartMentModel);

            var actual = target.Get();

            ScenarioContext.Current.Set(actual, "actual");
        }
        
        [Then(@"人員資訊取得為""(.*)""的資料")]
        public void Then人員資訊取得為的資料(string p0, Table table)
        {
            var actual = ScenarioContext.Current.Get<IEnumerable<PersonInfo>>("actual").ToList().ToExpectedObject();
            var expected = table.CreateSet<PersonInfo>();
            actual.ShouldEqual(expected);
        }
    }
}

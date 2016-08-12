using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POGOProtos.Networking.Envelopes;
using PokemonGo;
using PokemonGo.RocketAPI;
using PokemonGo.RocketAPI.Enums;
using PokemonGo.RocketAPI.Exceptions;
using PokemonGo.RocketAPI.Extensions;
using PokemonGo.RocketAPI.Helpers;
using PokemonGo.RocketAPI.HttpClient;
using PokemonGo.RocketAPI.Login;
using PokemonGo.RocketAPI.Rpc;

namespace RocketAPI {
    class Program {
        static void Main(string[] args) {
            string googleUserName = "";
            string googlePassword = "";
            Client aaTATaa = new Client(new Setting(googleUserName,googlePassword), new ApiFailureStrategy());
            aaTATaa.Login.DoLogin();
            Console.WriteLine(aaTATaa.Player.GetPlayerProfile("aaTATaa").ToString());
            Console.ReadKey();
        }
    }

    class Setting : ISettings {
        public AuthType AuthType { get; set; }
        public double DefaultAltitude { get; set; }
        public double DefaultLatitude { get; set; }
        public double DefaultLongitude { get; set; }
        public string GooglePassword { get; set; }
        public string GoogleRefreshToken { get; set; }
        public string GoogleUsername { get; set; }
        public string PtcPassword { get; set; }
        public string PtcUsername { get; set; }

        public Setting(string _googleUserName,string _googlePassword) {
            AuthType = AuthType.Google;
            DefaultAltitude = 10.0;
            DefaultLatitude = 40.785091;
            DefaultLongitude = -73.968285;
            GoogleUsername = _googleUserName;
            GooglePassword = _googlePassword;
        }
    }

    class ApiFailureStrategy : IApiFailureStrategy {
        public Task<ApiOperation> HandleApiFailure(RequestEnvelope request, ResponseEnvelope response) {
            throw new NotImplementedException();
        }

        public void HandleApiSuccess(RequestEnvelope request, ResponseEnvelope response) {
            throw new NotImplementedException();
        }
    }
}

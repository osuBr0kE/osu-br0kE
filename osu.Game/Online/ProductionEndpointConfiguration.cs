// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Game.Online
{
    public class ProductionEndpointConfiguration : EndpointConfiguration
    {
        public ProductionEndpointConfiguration()
        {
            WebsiteUrl = APIUrl = @"https://osu-dev1.br0k3x.info";    // [    osu!br0kE-web    ] // CHANGE BACK IN PROD: https://lazer.br0k3x.info
            APIClientSecret = @"okHpgQVigVeWouVyJg6M88QaXx9q4Nqce7JxIFDV";//        [       Client Secret and ID          ] // CHANGE BACK IN PROD: ihONKExY2tNSeyvmddCjdf8V724x8MhQxoFg4VaI
            APIClientID = "1";//             [     Generate via php artisan        ] // same in prod

            SpectatorUrl = "https://spectator-dev1.br0k3x.info/spectator";//default: spectator.br0k3x.info/spectator          [                      ]
            MultiplayerUrl = "https://spectator-dev1.br0k3x.info/multiplayer";//default: spectator.br0k3x.info/multiplayer    [    SignalR server    ]
            MetadataUrl = "https://spectator-dev1.br0k3x.info/metadata";//default: spectator.br0k3x.info/metadata             [                      ]
            BeatmapSubmissionServiceUrl = "https://bss-dev1.br0k3x.info";//default: bss.br0k3x.info                       [   Beatmap Submission Service   ]
        }
    }
}

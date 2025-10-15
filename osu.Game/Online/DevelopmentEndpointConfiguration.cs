// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Game.Online
{
    public class DevelopmentEndpointConfiguration : EndpointConfiguration
    {
        public DevelopmentEndpointConfiguration()
        {
            // DEVELOPER ENDPOINTS - these are hosted on a seperate server (the developer's PC) and are not guaranteed to be online at all times.
            // defaults: osu-dev1.br0k3x.info, spectator-dev1.br0k3x.info, bss-dev1.br0k3x.info


            WebsiteUrl = APIUrl = @"https://osu-dev1.br0k3x.info";               // [          osu!br0kE-web              ]
            APIClientSecret = @"okHpgQVigVeWouVyJg6M88QaXx9q4Nqce7JxIFDV";//        [       Client Secret and ID          ]
            APIClientID = "1";//                                                    [     Generate via php artisan        ]

            SpectatorUrl = "https://spectator-dev1.br0k3x.info/spectator";//default: spectator.br0k3x.info/spectator          [                      ]
            MultiplayerUrl = "https://spectator-dev1.br0k3x.info/multiplayer";//default: spectator.br0k3x.info/multiplayer    [    SignalR server    ]
            MetadataUrl = "https://spectator-dev1.br0k3x.info/metadata";//default: spectator.br0k3x.info/metadata             [                      ]
            BeatmapSubmissionServiceUrl = "https://bss-dev1.br0k3x.info";//default: bss.br0k3x.info                       [   Beatmap Submission Service   ]
        }
    }
}

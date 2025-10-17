// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Game.Online
{
    public class DevelopmentEndpointConfiguration : EndpointConfiguration
    {
        public DevelopmentEndpointConfiguration()
        {
            WebsiteUrl = APIUrl = @"https://lazer.br0k3x.info";// [          osu!br0kE-web              ]
            APIClientSecret = @"nqMg6qIQumjQ07acUN1MhTER4f8GzAzHnRwyw1AS";//        [       Client Secret and ID          ]
            APIClientID = "1";//                                                    [     Generate via php artisan        ]

            SpectatorUrl = "https://spectator.br0k3x.info/spectator";//default: spectator.br0k3x.info/spectator          [                      ]
            MultiplayerUrl = "https://spectator.br0k3x.info/multiplayer";//default: spectator.br0k3x.info/multiplayer    [    SignalR server    ]
            MetadataUrl = "https://spectator.br0k3x.info/metadata";//default: spectator.br0k3x.info/metadata             [                      ]
            BeatmapSubmissionServiceUrl = "https://bss.br0k3x.info";//default: bss.br0k3x.info                       [   Beatmap Submission Service   ]
        }
    }
}

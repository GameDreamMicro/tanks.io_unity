﻿//
//  Copyright (c) 2017  FederationOfCoders.org
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using UnityEngine;
using UnityEngine.UI;
using Tienkio.Tanks;

namespace Tienkio.UI {
    public class ScoreRenderer : MonoBehaviour {
        public ScoreCounter counter;
        public TankUpgrader tankUpgrader;

        public Text scoreLabel, levelLabel, upgradePointsLabel;
        public LevelBar levelBar;

        public void UpdateScoreLabel() {
            scoreLabel.text = string.Format("Score: {0}", counter.score.ToString("#,##0"));
        }

        public void UpdateLevelLabel() {
            levelLabel.text = string.Format("Lvl {0} {1}", counter.currentLevel.index,
                                            tankUpgrader.currentUpgradeNode.tankName);
            levelBar.UpdateBar();
        }

        public void UpdateUpgradePointsLabel() {
            upgradePointsLabel.text = string.Format("x{0}", counter.upgradePoints);
        }
    }
}

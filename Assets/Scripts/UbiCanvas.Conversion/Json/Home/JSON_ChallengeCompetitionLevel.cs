using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_ChallengeCompetitionLevel {
		// in homeconfig
		public string MapID { get; set; }
		public uint Mode { get; set; } // 0 - default, 1 - lums attack, 2 - time attack
		public uint Frequency { get; set; }
		public float Objective { get; set; }
		public float ScoreValidation { get; set; }
		public string Path { get; set; }
	}
}

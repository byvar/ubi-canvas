using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class VertexAnim : BaseObject {
		public float animGlobalSpeed;
		public Angle animGlobalRotSpeed;
		public float animSpeedX;
		public float animSpeedY;
		public float animSyncX;
		public float animSyncY;
		public float animAmplitudeX;
		public float animAmplitudeY;
		public float animSync;
		public bool animAngleUsed;
		public Angle animAngle;

		public VertexAnim(Reader reader) : base(reader) {
			animGlobalSpeed = reader.ReadSingle();
			animGlobalRotSpeed = new Angle(reader);
			animSpeedX = reader.ReadSingle();
			animSpeedY = reader.ReadSingle();
			animSyncX = reader.ReadSingle();
			animSyncY = reader.ReadSingle();
			animAmplitudeX = reader.ReadSingle();
			animAmplitudeY = reader.ReadSingle();
			animSync = reader.ReadSingle();
			animAngleUsed = reader.ReadBoolean();
			animAngle = new Angle(reader);
		}
	}
}

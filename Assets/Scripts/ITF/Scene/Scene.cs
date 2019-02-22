using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Scene : BaseObject {
		public uint engineVersion;
		public Container<Path> dependencies;
		public Container<Frise> frise;
		public Container<MetaFrieze> metafrieze;
		public Container<Actor> actors;
		public Container<FriezeConnectionResult> friezeConnections;
		public SceneConfigs sceneConfigs;


		public Scene(Reader reader) : base(reader) {
			engineVersion = reader.ReadUInt32();
			dependencies = new Container<Path>(reader);
			frise = new Container<Frise>(reader);
			metafrieze = new Container<MetaFrieze>(reader);
			actors = new Container<Actor>(reader, true);
			friezeConnections = new Container<FriezeConnectionResult>(reader);
			sceneConfigs = new SceneConfigs(reader);
		}
	}
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Conversion.Json;

namespace UbiCanvas.Conversion {
	public class SimpleObjectBuilder : ProjectBuilder {

		public SimpleObjectBuilder(string projectPath) : base(projectPath) {
		}

		public override string ID => "simpleobject";

		protected override async Task BuildInternal() {
			var inPath = System.IO.Path.Combine(ProjectPath, "json", "simpleobject");


			// Use alphabetical order. To prioritize a file being added, prefix the mod name with _
			foreach (var dir in System.IO.Directory.EnumerateDirectories(inPath).OrderBy(p => p)) {
				//string dirPath = dir.Substring(inputPath.Length).Replace('\\', '/').Trim('/');
				string dirPath = dir.Replace('\\', '/').Trim('/');
				foreach (string file in System.IO.Directory.GetFiles(dir, "*.json", System.IO.SearchOption.AllDirectories)) {
					string relativePath = file.Substring(dirPath.Length).Replace('\\', '/').TrimStart('/');

					string uncookedPath = relativePath;
					uncookedPath = uncookedPath.Substring(0, uncookedPath.LastIndexOf('.'));
					var cookedPath = new Path(uncookedPath).CookedPath(TargetContext);

					if (!FileIsAlreadyBuilt(cookedPath)) {
						var json = System.IO.File.ReadAllText(file);

						if (uncookedPath.ToLowerInvariant().EndsWith(".isc")) {
							var simpleISC = JsonConvert.DeserializeObject<JSON_SimpleScene>(json);
							var isc = new Scene();

							isc.ACTORS = new CArrayO<Generic<Actor>>();
							isc.FRISE = new CListO<Frise>();
							if (simpleISC.Actor != null) {
								foreach (var simpleACT in simpleISC.Actor) {
									var act = await CreateActor(simpleACT);
									isc.AddActor(act, simpleACT.Name);
								}
							}
							if (simpleISC.Frise != null) {
								foreach (var simpleF in simpleISC.Frise) {
									var f = await CreateFrise(simpleF);
									isc.FRISE.Add(f);
								}
							}

							var iscFile = new ContainerFile<Scene>() {
								read = true,
								obj = isc
							};
							Bundle.AddFile(cookedPath, iscFile);
						} else if (uncookedPath.ToLowerInvariant().EndsWith(".fcg")) {
							var simpleFCG = JsonConvert.DeserializeObject<JSON_SimpleFriseConfig>(json);
							var fcg = new FriseConfig();

							// TODO

							var fcgFile = new GenericFile<FriseConfig>(fcg);
							Bundle.AddFile(cookedPath, fcgFile);
						}
					}
				}
			}
		}

		protected void FillPickable(Pickable pickable, JSON_SimplePickable simple) {
			pickable.POS2D = simple.Position;
			pickable.SCALE = simple.Scale;
			pickable.RELATIVEZ = simple.Z;
			pickable.ANGLE = simple.Angle;
			pickable.USERFRIENDLY = simple.Name;
			pickable.xFLIPPED = simple.XFlip;
		}

		protected async Task<Actor> CreateActor(JSON_SimplePickable simple) {
			Actor act;
			if (simple.TemplatePath.ToLowerInvariant().EndsWith(".tpl")) {
				var pTPL = new Path(simple.TemplatePath);
				var tpl = await LoadFileFromPatchData<GenericFile<Actor_Template>>(TargetContext, simple.TemplatePath);
				act = tpl.obj.Instantiate(pTPL);
			} else {
				var actContainer = await LoadFileFromPatchData<ContainerFile<Actor>>(TargetContext, simple.TemplatePath);
				act = (Actor)(await TargetContext.Loader.Clone(actContainer.obj, "act"));
			}

			FillPickable(act, simple);
			return act;
		}
		protected async Task<Frise> CreateFrise(JSON_SimpleFrise simple) {
			Frise fr = new Frise();
			fr.ConfigName = new Path(simple.TemplatePath);

			// TODO: Update points list
			/*fr.PointsList = new PolyPointList() {
				LocalPoints = new CListO<PolyLineEdge>(new List<PolyLineEdge>() {
					new PolyLineEdge() {
						
					},
				}),
				Loop = simple.Loop,
			};*/

			// TODO: update AABBs etc

			FillPickable(fr, simple);
			return fr;
		}
	}
}

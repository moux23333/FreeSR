namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityUpdateScNotify
	{
		[ProtoMember(6)] public List<SceneEntityInfo> EntityList;
	}
	
}

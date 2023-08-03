namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class JCDOMCEKHIF
	{
		[ProtoMember(15)] public List<SceneEntityInfo> EntityList;
		[ProtoMember(5)] public int GroupId;
		[ProtoMember(11)] public int State;
	}
	
}

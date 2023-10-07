namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LCKCOFLDGDO
	{
		[ProtoMember(9)] public int GroupId;
		[ProtoMember(5)] public List<SceneEntityInfo> EntityList;
		[ProtoMember(1)] public int State;
	}

}

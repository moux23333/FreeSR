namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityMoveCsReq
	{
		[ProtoMember(5)] public List<EntityMotion> EntityMotionList;
		[ProtoMember(9)] public int EntryId;
		[ProtoMember(10)] public long Ecmcbpijpmf;
	}

}

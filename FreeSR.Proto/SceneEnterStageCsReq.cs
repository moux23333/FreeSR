namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEnterStageCsReq
	{
		[ProtoMember(10)] public int EventId;
	}
	
}

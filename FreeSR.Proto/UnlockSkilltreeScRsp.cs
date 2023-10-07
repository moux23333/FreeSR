namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UnlockSkilltreeScRsp
	{
		[ProtoMember(15)] public int Retcode;
		[ProtoMember(8)] public int Level;
		[ProtoMember(10)] public int BaseAvatarId;
		[ProtoMember(2)] public int PointId;
	}

}

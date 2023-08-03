namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UnlockSkilltreeScRsp
	{
		[ProtoMember(3)] public int PointId;
		[ProtoMember(15)] public int BaseAvatarId;
		[ProtoMember(1)] public int Level;
		[ProtoMember(12)] public int Retcode;
	}
	
}

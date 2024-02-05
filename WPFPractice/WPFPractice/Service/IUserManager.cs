using WPFPractice.Model;

namespace WPFPractice.Service {
    internal interface IUserManager {
        internal void Register(string id, string pw, string userName); // 회원가입
        internal User SignIn(string id, string pw); // 로그인
    }
}

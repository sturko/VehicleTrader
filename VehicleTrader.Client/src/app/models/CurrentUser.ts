export class CurrentUser {
    constructor(
        public Id: string,
        public UserName: string,

        public ProfileId?: number,
        public Email?: string,
        public FirstName?: string,
        public LastName?: string,
        public PhoneNumber?: string,
        public AvatarUrl?: string,
        public IsEmailVerified?: boolean,
        public Roles: Array<string> = [],
    ) { }
}
services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

services.AddAuthentication()
    .AddWsFederation(options =>
    {
        // MetadataAddress represents the Active Directory instance used to authenticate users.
        options.MetadataAddress = "https://<ADFS FQDN or AAD tenant>/FederationMetadata/2007-06/FederationMetadata.xml";

        // Wtrealm is the app's identifier in the Active Directory instance.
        // For ADFS, use the relying party's identifier, its WS-Federation Passive protocol URL:
        options.Wtrealm = "https://localhost:44307/";

        // For AAD, use the App ID URI from the app registration's Properties blade:
        options.Wtrealm = "https://wsfedsample.onmicrosoft.com/bf0e7e6d-056e-4e37-b9a6-2c36797b9f01";
    });

services.AddMvc()

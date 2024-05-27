import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Shop',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44398/',
    redirectUri: baseUrl,
    clientId: 'Shop_App',
    responseType: 'code',
    scope: 'offline_access Shop',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44330',
      rootNamespace: 'BMS.Shop',
    },
  },
} as Environment;

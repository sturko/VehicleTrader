import { INavbarData } from "./helper";

export const navbarData: INavbarData[] = [
    {
        routeLink: '',
        icon: 'fal fa-home',
        label: 'Home'
    },
    {
        routeLink: 'vehicles',
        icon: 'fal fa-car-bus',
        label: 'Vehicles',
        items: [
            {
                routeLink: 'vehicles/used-cars',
                icon: 'fal fa-car-side',
                label: 'Cars',
            },
            {
                routeLink: 'vehicles/bikes',
                icon: 'fal fa-motorcycle',
                label: 'Bikes',
            },
            {
                routeLink: 'vehicles/planes',
                icon: 'fal fa-plane',
                label: 'Planes',
            },
            {
                routeLink: 'vehicles/ships',
                icon: 'fal fa-ship',
                label: 'Ships',
            }
        ]
    },
    {
        routeLink: 'settings',
        icon: 'fal fa-cog',
        label: 'Settings'
    },
];